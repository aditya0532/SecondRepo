using System;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime;

namespace HelloAutoCad

{
    public class Class1
    {
        [CommandMethod("HelloAutoCad")]
        public void HelloAutoCADFromCSharp()
        {
            Document document = Application.DocumentManager.MdiActiveDocument;
            Database db = document.Database;
           Editor   editor= document.Editor;

            editor.WriteMessage("Hello AutoCAD with C# Automation.....!!!!!");
        }
    }
}