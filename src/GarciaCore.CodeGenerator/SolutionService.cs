﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GarciaCore.CodeGenerator
{
    public class SolutionService : ISolutionService
    {
        public async Task<Solution> CreateSampleSolutionAsync()
        {
            var solution = new Solution("TestSolution", "c:\\files\\garciacoretest");

            var infrastructure = new Project("TestSolution.Infrastructure", ProjectType.ClassLibrary);
            infrastructure.AddGenerator("Repository", "Repository", new RepositoryGenerator());
            solution.Projects.Add(infrastructure);

            var domain = new Project("TestSolution.Domain", ProjectType.ClassLibrary);
            domain.AddGenerator("Entity", "Entity", new EntityGenerator());
            domain.ProjectDependencies.Add(infrastructure);
            solution.Projects.Add(domain);

            var api = new Project("TestSolution.Api", ProjectType.WebApi);
            api.AddGenerator("Controller", "Controllers", "ApiController", new CQRSWebApiControllerGenerator());
            api.ProjectDependencies.Add(infrastructure);
            api.ProjectDependencies.Add(domain);
            solution.Projects.Add(api);

            var application = new Project("TestSolution.Application", ProjectType.ClassLibrary);
            application.AddGenerator("Queries", "Queries", new CQRSWebApiQueryGenerator());
            application.AddGenerator("CreateCommand", "Commands", new CQRSWebApiCreateCommandGenerator());
            application.AddGenerator("UpdateCommand", "Commands", new CQRSWebApiUpdateCommandGenerator());
            application.AddGenerator("DeleteCommand", "Commands", new CQRSWebApiDeleteCommandGenerator());
            application.AddGenerator("CreateCommandHandler", "Commands", new CQRSWebApiCreateCommandHandlerGenerator());
            application.AddGenerator("UpdateCommandHandler", "Commands", new CQRSWebApiUpdateCommandHandlerGenerator());
            application.AddGenerator("DeleteCommandHandler", "Commands", new CQRSWebApiDeleteCommandHandlerGenerator());
            solution.Projects.Add(application);

            return solution;
        }

        public async Task<SolutionModel> CreateSampleSolution2Async()
        {
            var model = new SolutionModel()
            {
                Name = "TestSolution",
                Folder = "c:\\files\\garciacoretest",
                Projects = new List<ProjectModel>()
                {
                    new ProjectModel()
                    {
                        Name = "TestSolution.Infrastructure",
                        ProjectType = ProjectType.ClassLibrary,
                        Generators = new List<ProjectGeneratorModel> { new ProjectGeneratorModel() { } }
                    }
                }
            };

            return model;
        }

        public async Task<SolutionGenerationResult> CreateSolutionAsync(string solutionJson)
        {
            //var solution = JsonConvert.DeserializeObject<Solution>(solutionJson);
            var solutionModel = JsonConvert.DeserializeObject<SolutionModel>(solutionJson);
            var messages = new List<string>();

            if (solutionModel == null)
                throw new CodeGeneratorException("Cannot convert json to SolutionModel, please check sample json.");

            var solution = new Solution(solutionModel.Name, solutionModel.Folder);
            var allProjects = new List<Project>();

            if (solutionModel.Projects != null)
            {
                foreach (var projectModel in solutionModel.Projects)
                {
                    var project = new Project(projectModel.Name, projectModel.Folder, projectModel.Namespace, projectModel.ProjectType);
                    project.Uid = projectModel.Uid;
                    solution.Projects.Add(project);
                    allProjects.Add(project);

                    if (projectModel.Generators != null)
                    {
                        foreach (var generatorModel in projectModel.Generators)
                        {
                            var type = Type.GetType($"GarciaCore.CodeGenerator.{generatorModel.GeneratorName}");

                            if (type == null)
                            {
                                messages.Add($"Generator with name {generatorModel.GeneratorName} could not be found in assembly GarciaCore.CodeGenerator.");
                            }
                            else
                            {
                                var generator = Activator.CreateInstance(type) as IGenerator;
                                project.AddGenerator(generatorModel.Name, generatorModel.Folder, generatorModel.Name, generatorModel.BaseClass, generator);
                            }
                        }
                    }
                }

                foreach (var projectModel in solutionModel.Projects)
                {
                    if (projectModel.ProjectDependencies != null)
                    {
                        foreach (var projectDependency in projectModel.ProjectDependencies)
                        {
                            var dependentProject = allProjects.FirstOrDefault(x => x.Name == projectDependency);

                            if (dependentProject == null)
                            {
                                messages.Add($"Project with name {projectDependency} could not be found in projects.");
                            }
                            else
                            {
                                var project = allProjects.FirstOrDefault(x => x.Uid == projectModel.Uid);
                                if (project == null)
                                    messages.Add($"Project with Uid {projectModel.Uid} could not be found in projects.");
                                else
                                    project.ProjectDependencies.Add(dependentProject);
                            }
                        }
                    }
                }
            }

            return new SolutionGenerationResult(solution, messages);
        }

        public async Task<string> GetSampleJsonAsync()
        {
            var solution = await CreateSampleSolutionAsync();
            return JsonConvert.SerializeObject(solution, Formatting.Indented, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
        }

        public async Task<string> GetSolutionJsonAsync(Solution solution)
        {
            return JsonConvert.SerializeObject(solution, Formatting.Indented, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
        }
    }
}