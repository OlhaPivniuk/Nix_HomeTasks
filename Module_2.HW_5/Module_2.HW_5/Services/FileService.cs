using Module_2.HW_5.Services.Abstractions;

namespace Module_2.HW_5.Services
{
    public class FileService : IFileService
    {
        public string Read(string path)
        {
            return File.ReadAllText(path);
        }

        public IDisposable Create(string path)
        {
            FileInfo fileInfo = new (path);

            if (!fileInfo.Exists)
            {
                fileInfo.Create().Close();
            }

            return new StreamWriter(path, true, System.Text.Encoding.Default);
        }

        public void Write(IDisposable streamWriter, string data)
        {
            StreamWriter sWriter = streamWriter as StreamWriter;

            sWriter?.WriteLine(data);
            sWriter?.Flush();
        }

        public void Close(IDisposable streamWriter)
        {
            StreamWriter sWriter = streamWriter as StreamWriter;

            sWriter?.Close();
            sWriter?.Dispose();
        }
    }
}
