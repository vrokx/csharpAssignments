//Check whether file is exists or not at particular location
bool isFileExists = File.Exists(@"C:\ DummyFile.txt"); // returns false

//Copy DummyFile.txt as new file DummyFileNew.txt
File.Copy(@"C:\DummyFile.txt", @"D:\NewDummyFile.txt");

//Get when the file was accessed last time 
DateTime lastAccessTime = File.GetLastAccessTime(@"C:\DummyFile.txt");

//get when the file was written last time
DateTime lastWriteTime = File.GetLastWriteTime(@"C:\DummyFile.txt");

// Move file to new location
File.Move(@"C:\DummyFile.txt", @"D:\DummyFile.txt");

//Open file and returns FileStream for reading bytes from the file
FileStream fs = File.Open(@"D:\DummyFile.txt", FileMode.OpenOrCreate);

//Open file and return StreamReader for reading string from the file
StreamReader sr = File.OpenText(@"D:\DummyFile.txt");

//Delete file
File.Delete(@"C:\DummyFile.txt");