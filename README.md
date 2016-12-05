# Tidy Architecture Template

A starting point for building a monolith architecture in C#.

## Installing the template

1. Download the latest release
1. Copy the zip file to `C:\Users\<username>\Visual Studio <version>\Templates`

## Using the template

1. Open Visual Studio
1. Go to `File > New Project`
1. Select the `Tidy Architecture Solution Template`

### HACK
Unfortunately, due to a bug developing multi-project templates for Visual Studio, an extra folder is created when you generate the project, which will interfere with some NuGet packages. 

You have to perform the following extra steps in order to get the project to build.

1. Click on your Solution in Solution Explorer.
1. Go to `File > Save As`
1. Save the solution file in the extra folder.
1. Delete the original solution file.
1. Move all files in the extra folder into the parent folder.
1. Delete the extra folder.