<<<<<<< HEAD
using System;
using System.IO;
using System.Text;

namespace Packages.Rider.Editor {
  class FileIOProvider : IFileIO
  {
    public bool Exists(string fileName)
    {
      return File.Exists(fileName);
    }

    public string ReadAllText(string fileName)
    {
      return File.ReadAllText(fileName);
    }

    public void WriteAllText(string fileName, string content)
    {
      File.WriteAllText(fileName, content, Encoding.UTF8);
    }
  }
}
=======
using System;
using System.IO;
using System.Text;

namespace Packages.Rider.Editor {
  class FileIOProvider : IFileIO
  {
    public bool Exists(string fileName)
    {
      return File.Exists(fileName);
    }

    public string ReadAllText(string fileName)
    {
      return File.ReadAllText(fileName);
    }

    public void WriteAllText(string fileName, string content)
    {
      File.WriteAllText(fileName, content, Encoding.UTF8);
    }
  }
}
>>>>>>> 4692023cef52aa56104ab5e022258e42b3aa9d4e
