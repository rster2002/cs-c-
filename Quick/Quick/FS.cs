using System;
using System.Collections.Generic;
using System.IO;

namespace Quick {
    namespace FS {
        namespace FS {
            public class FileRef {
                public string filePath;

                public FileRef(string filePath) {
                    this.filePath = filePath;
                }

                private void internalWriteLines(string path, List<string> lines) {
                    StreamWriter streamWriter = new StreamWriter(path: path);

                    foreach (string line in lines) {
                        streamWriter.WriteLine(line);
                    }

                    streamWriter.Close();
                }

                private void internalAppendLines(string path, List<string> lines) {
                    StreamWriter streamWriter = new StreamWriter(path: path, append: true);

                    foreach (string line in lines) {
                        streamWriter.WriteLine(line);
                    }

                    streamWriter.Close();
                }

                private List<string> internalReadToList(string path) {
                    if (File.Exists(path)) {
                        List<string> lines = new List<string>();
                        StreamReader streamReader = new StreamReader(path);

                        while (!streamReader.EndOfStream) {
                            lines.Add(streamReader.ReadLine());
                        }

                        streamReader.Close();

                        return lines;
                    } else {
                        throw new Exception("Files does not exists");
                    }
                }

                public void writeLines(List<string> lines) {
                    internalWriteLines(path: filePath, lines: lines);
                }

                public void writeLines(string path, List<string> lines) {
                    internalWriteLines(path: path, lines: lines);
                }

                public void appendLines(List<string> lines) {
                    internalAppendLines(path: filePath, lines: lines);
                }

                public void appendLines(string path, List<string> lines) {
                    internalAppendLines(path: path, lines: lines);
                }

                public List<string> readToList() {
                    return internalReadToList(path: filePath);
                }

                public List<string> readToList(string path) {
                    return internalReadToList(path: path);
                }

                private void internalForLines(string path, Action<string> action) {
                    List<string> lines = internalReadToList(path: path);

                    foreach (string line in lines) {
                        action(line);
                    }
                }

                public void forLines(Action<string> action) {
                    internalForLines(path: filePath, action: action);
                }

                public void forLines(string path, Action<string> action) {
                    internalForLines(path: path, action: action);
                }
            }
        }
    }
}
