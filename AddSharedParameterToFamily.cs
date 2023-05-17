// Decompiled with JetBrains decompiler
// Type: RBG_VSNodes.Document
// Assembly: Dyn_SharedParamTesting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2C070C38-E2E5-4BF9-9F78-A42E293E0A2B
// Assembly location: C:\Users\CHATPONG\AppData\Roaming\Dynamo\Dynamo Revit\2.16\packages\DYN_SharedParamTesting\bin\Dyn_SharedParamTesting.dll

using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;

namespace RBG_VSNodes
{
    public class Document
    {
        public static List<string> GetSharedParamsGroupNames()
        {
            Autodesk.Revit.DB.Document currentDbDocument = DocumentManager.Instance.CurrentDBDocument;
            List<string> paramsGroupNames = new List<string>();
            foreach (DefinitionGroup group in currentDbDocument.Application.OpenSharedParameterFile().Groups)
                paramsGroupNames.Add(group.Name);
            return paramsGroupNames;
        }

        public static List<List<string>> GetSharedParamsInGroup(string GroupName)
        {
            Autodesk.Revit.DB.Document currentDbDocument = DocumentManager.Instance.CurrentDBDocument;
            List<List<string>> sharedParamsInGroup = new List<List<string>>();
            foreach (DefinitionGroup group in currentDbDocument.Application.OpenSharedParameterFile().Groups)
            {
                if (group.Name == GroupName)
                {
                    foreach (Definition definition in group.Definitions)
                        sharedParamsInGroup.Add(new List<string>()
            {
              definition.Name
            });
                }
            }
            return sharedParamsInGroup;
        }

        public static string AddSharedParamsToFamily(
          string SPParameterName,
          string SPGroupName,
          string BuiltInPG,
          bool IsInstance)
        {
            string family = "Failed!!!";
            Autodesk.Revit.DB.Document currentDbDocument = DocumentManager.Instance.CurrentDBDocument;
            BuiltInParameterGroup parameterGroup = BuiltInParameterGroup.INVALID;
            foreach (BuiltInParameterGroup inParameterGroup in Enum.GetValues(typeof(BuiltInParameterGroup)))
            {
                if (inParameterGroup.ToString() == BuiltInPG)
                    parameterGroup = inParameterGroup;
            }
            if (currentDbDocument.IsFamilyDocument)
            {
                FamilyManager familyManager = currentDbDocument.FamilyManager;
                foreach (DefinitionGroup group in currentDbDocument.Application.OpenSharedParameterFile().Groups)
                {
                    if (group.Name == SPGroupName)
                    {
                        using (IEnumerator<Definition> enumerator = group.Definitions.GetEnumerator())
                        {
                            while (enumerator.MoveNext())
                            {
                                ExternalDefinition current = (ExternalDefinition)enumerator.Current;
                                if (current.Name == SPParameterName)
                                {
                                    TransactionManager.Instance.EnsureInTransaction(currentDbDocument);
                                    try
                                    {
                                        familyManager.AddParameter(current, parameterGroup, IsInstance);
                                        family = "Oh Yeah Baby!!!";
                                    } catch (Exception ex)
                                    {
                                        family = ex.Message;
                                    }
                                    TransactionManager.Instance.TransactionTaskDone();
                                }
                            }
                            break;
                        }
                    }
                }
            } else
                family = "The current Document is not a Family Document";
            return family;
        }
    }
}
