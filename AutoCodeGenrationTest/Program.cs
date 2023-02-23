// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using OpenApiIntegrationLibrary;
using System;
using System.Collections.Generic;

Console.WriteLine("Welcome to AutoCodeGenration usng Chat GPT Open AI !");

Console.WriteLine("AutoCodeGenration process initiated by open api, please dont close window or click any button untill any further instruction.......");

OpenApiIntegration apiIntegration = new OpenApiIntegration();


var file1 = new FileInformation();
file1.FileName = "Division";
file1.FilePath = @"C:\\Users\\rajendra.m\\Desktop\\Private\\Study\\GitRepo\\Test\\Source\Division.cs";

var file2 = new FileInformation();
file2.FileName = "Addition";
file2.FilePath = @"C:\\Users\\rajendra.m\\Desktop\\Private\\Study\\GitRepo\\Test\\Source\Addition.cs";

var file3 = new FileInformation();
file3.FileName = "Multiplication";
file3.FilePath = @"C:\\Users\\rajendra.m\\Desktop\\Private\\Study\\GitRepo\\Test\\Source\Multiplication.cs";

var file4 = new FileInformation();
file4.FileName = "Substraction";
file4.FilePath = @"C:\\Users\\rajendra.m\\Desktop\\Private\\Study\\GitRepo\\Test\\Source\Substraction.cs";

var codeFileList = new List<FileInformation>();
codeFileList.Add(file1);
codeFileList.Add(file2);
codeFileList.Add(file3);
codeFileList.Add(file4); 



var result = await apiIntegration.PerformOperation(codeFileList, "# Can you write c# unit test using MSTest framework cases for given code", @"C:\Users\rajendra.m\Desktop\Private\Study\GitRepo\Test\Destination");

//var result = await apiIntegration.EditCodeFilesForCommentAndErrorCheck(); 

//var result = await apiIntegration.CreateUnitTestFiles();

Console.WriteLine("Is Process completed. ? => " + result);

//Console.WriteLine("You can close the window now and check the appropriate folders for resulting files..");