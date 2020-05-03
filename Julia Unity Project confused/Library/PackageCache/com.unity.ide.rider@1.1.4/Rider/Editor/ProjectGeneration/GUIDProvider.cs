<<<<<<< HEAD
using System;

namespace Packages.Rider.Editor {
  class GUIDProvider : IGUIDGenerator
  {
    public string ProjectGuid(string projectName, string assemblyName)
    {
      return SolutionGuidGenerator.GuidForProject(projectName + assemblyName);
    }

    public string SolutionGuid(string projectName, string extension)
    {
      return SolutionGuidGenerator.GuidForSolution(projectName, extension); // GetExtensionOfSourceFiles(assembly.sourceFiles)
    }
  }
}
=======
using System;

namespace Packages.Rider.Editor {
  class GUIDProvider : IGUIDGenerator
  {
    public string ProjectGuid(string projectName, string assemblyName)
    {
      return SolutionGuidGenerator.GuidForProject(projectName + assemblyName);
    }

    public string SolutionGuid(string projectName, string extension)
    {
      return SolutionGuidGenerator.GuidForSolution(projectName, extension); // GetExtensionOfSourceFiles(assembly.sourceFiles)
    }
  }
}
>>>>>>> 4692023cef52aa56104ab5e022258e42b3aa9d4e
