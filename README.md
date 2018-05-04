# Working with files in `C#`

## Namespace in classes

* `System.IO`
    * `File`, `FileInfo` - Provide methodes for creating, copying, deleting, moving and opening of files.
        * `File` provides static methods, good for small number of operations on file. Problem: Everytime we call `File`'s static method, it checks, if user has access to the file.
        * `FileInfo` provides instance methods
            * Some methods - `Create()`, `Copy()`, `Delete()`, `Exists()`, `GetAttributes()`, `Move()`, `ReadAllText()`
    * `Directory`, `DirectoryInfo`
        * `Directory` provides static methods, good for small number of operations on file. Problem: Everytime we call `File`'s static method, it checks, if user has access to the file.
        * `DirectoryInfo` provides instance methods
            * Some methods - `CreateDirectory()`, `Delete()`, `Exists()`, `GetCurrentDirectory()`, `GetFiles()`, `Move()`, `GetLogicalDrives()`
    * `Path`
        * Some Methods - `GetDirectoryName()`,`GetFileName()`,`GetExtension()`,`GetTempPath()`
