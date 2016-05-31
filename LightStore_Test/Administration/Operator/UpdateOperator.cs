using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace LightStore_Test
{
    [TestClass()]
    public class UpdateOperator : SqlDatabaseTestClass
    {

        public UpdateOperator()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Update_All_Fields_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaCondition1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateOperator));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition ValueReturnedBySP;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Update_All_Fields_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction NULL_Values_Keeps_Same_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition5;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition6;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition7;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition8;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition9;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction EMPTY_Values_Reset_Email_And_Password_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition10;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition11;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction EMPTY_Values_Reset_Email_And_Password_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction NULL_Values_Keeps_Same_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Update_Password_Set_Password_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition12;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Update_Password_Set_Password_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Error_FirstName_EMPTY_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Error_LastName_EMPTY_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Error_Unknown_Operator_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Error_FirstName_EMPTY_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Error_LastName_EMPTY_PretestAction;
            this.Update_All_FieldsData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.NULL_Values_Keeps_SameData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.EMPTY_Values_Reset_Email_And_PasswordData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.Update_Password_Set_PasswordData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.Error_FirstName_EMPTYData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.Error_LastName_EMPTYData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.Error_Unknown_OperatorData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            Update_All_Fields_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            expectedSchemaCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            rowCountCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            scalarValueCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            scalarValueCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            scalarValueCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            scalarValueCondition4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            ValueReturnedBySP = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Update_All_Fields_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            NULL_Values_Keeps_Same_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            expectedSchemaCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            scalarValueCondition5 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            scalarValueCondition6 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            scalarValueCondition7 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            scalarValueCondition8 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            scalarValueCondition9 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            EMPTY_Values_Reset_Email_And_Password_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition10 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            scalarValueCondition11 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            EMPTY_Values_Reset_Email_And_Password_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            NULL_Values_Keeps_Same_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Update_Password_Set_Password_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition12 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Update_Password_Set_Password_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Error_FirstName_EMPTY_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            Error_LastName_EMPTY_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            Error_Unknown_Operator_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            Error_FirstName_EMPTY_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Error_LastName_EMPTY_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            // 
            // Update_All_Fields_TestAction
            // 
            Update_All_Fields_TestAction.Conditions.Add(expectedSchemaCondition1);
            Update_All_Fields_TestAction.Conditions.Add(rowCountCondition1);
            Update_All_Fields_TestAction.Conditions.Add(scalarValueCondition1);
            Update_All_Fields_TestAction.Conditions.Add(scalarValueCondition2);
            Update_All_Fields_TestAction.Conditions.Add(scalarValueCondition3);
            Update_All_Fields_TestAction.Conditions.Add(scalarValueCondition4);
            Update_All_Fields_TestAction.Conditions.Add(ValueReturnedBySP);
            resources.ApplyResources(Update_All_Fields_TestAction, "Update_All_Fields_TestAction");
            // 
            // expectedSchemaCondition1
            // 
            expectedSchemaCondition1.Enabled = true;
            expectedSchemaCondition1.Name = "expectedSchemaCondition1";
            resources.ApplyResources(expectedSchemaCondition1, "expectedSchemaCondition1");
            expectedSchemaCondition1.Verbose = false;
            // 
            // rowCountCondition1
            // 
            rowCountCondition1.Enabled = true;
            rowCountCondition1.Name = "rowCountCondition1";
            rowCountCondition1.ResultSet = 1;
            rowCountCondition1.RowCount = 1;
            // 
            // scalarValueCondition1
            // 
            scalarValueCondition1.ColumnNumber = 2;
            scalarValueCondition1.Enabled = true;
            scalarValueCondition1.ExpectedValue = "New_FirstName";
            scalarValueCondition1.Name = "scalarValueCondition1";
            scalarValueCondition1.NullExpected = false;
            scalarValueCondition1.ResultSet = 1;
            scalarValueCondition1.RowNumber = 1;
            // 
            // scalarValueCondition2
            // 
            scalarValueCondition2.ColumnNumber = 3;
            scalarValueCondition2.Enabled = true;
            scalarValueCondition2.ExpectedValue = "New_LastName";
            scalarValueCondition2.Name = "scalarValueCondition2";
            scalarValueCondition2.NullExpected = false;
            scalarValueCondition2.ResultSet = 1;
            scalarValueCondition2.RowNumber = 1;
            // 
            // scalarValueCondition3
            // 
            scalarValueCondition3.ColumnNumber = 5;
            scalarValueCondition3.Enabled = true;
            scalarValueCondition3.ExpectedValue = "New_Email";
            scalarValueCondition3.Name = "scalarValueCondition3";
            scalarValueCondition3.NullExpected = false;
            scalarValueCondition3.ResultSet = 1;
            scalarValueCondition3.RowNumber = 1;
            // 
            // scalarValueCondition4
            // 
            scalarValueCondition4.ColumnNumber = 6;
            scalarValueCondition4.Enabled = true;
            scalarValueCondition4.ExpectedValue = "True";
            scalarValueCondition4.Name = "scalarValueCondition4";
            scalarValueCondition4.NullExpected = false;
            scalarValueCondition4.ResultSet = 1;
            scalarValueCondition4.RowNumber = 1;
            // 
            // ValueReturnedBySP
            // 
            ValueReturnedBySP.ColumnNumber = 1;
            ValueReturnedBySP.Enabled = true;
            ValueReturnedBySP.ExpectedValue = "1";
            ValueReturnedBySP.Name = "ValueReturnedBySP";
            ValueReturnedBySP.NullExpected = false;
            ValueReturnedBySP.ResultSet = 2;
            ValueReturnedBySP.RowNumber = 1;
            // 
            // Update_All_Fields_PretestAction
            // 
            resources.ApplyResources(Update_All_Fields_PretestAction, "Update_All_Fields_PretestAction");
            // 
            // NULL_Values_Keeps_Same_TestAction
            // 
            NULL_Values_Keeps_Same_TestAction.Conditions.Add(expectedSchemaCondition2);
            NULL_Values_Keeps_Same_TestAction.Conditions.Add(scalarValueCondition5);
            NULL_Values_Keeps_Same_TestAction.Conditions.Add(scalarValueCondition6);
            NULL_Values_Keeps_Same_TestAction.Conditions.Add(scalarValueCondition7);
            NULL_Values_Keeps_Same_TestAction.Conditions.Add(scalarValueCondition8);
            NULL_Values_Keeps_Same_TestAction.Conditions.Add(scalarValueCondition9);
            resources.ApplyResources(NULL_Values_Keeps_Same_TestAction, "NULL_Values_Keeps_Same_TestAction");
            // 
            // expectedSchemaCondition2
            // 
            expectedSchemaCondition2.Enabled = true;
            expectedSchemaCondition2.Name = "expectedSchemaCondition2";
            resources.ApplyResources(expectedSchemaCondition2, "expectedSchemaCondition2");
            expectedSchemaCondition2.Verbose = false;
            // 
            // scalarValueCondition5
            // 
            scalarValueCondition5.ColumnNumber = 1;
            scalarValueCondition5.Enabled = true;
            scalarValueCondition5.ExpectedValue = "1";
            scalarValueCondition5.Name = "scalarValueCondition5";
            scalarValueCondition5.NullExpected = false;
            scalarValueCondition5.ResultSet = 1;
            scalarValueCondition5.RowNumber = 1;
            // 
            // scalarValueCondition6
            // 
            scalarValueCondition6.ColumnNumber = 2;
            scalarValueCondition6.Enabled = true;
            scalarValueCondition6.ExpectedValue = "1";
            scalarValueCondition6.Name = "scalarValueCondition6";
            scalarValueCondition6.NullExpected = false;
            scalarValueCondition6.ResultSet = 1;
            scalarValueCondition6.RowNumber = 1;
            // 
            // scalarValueCondition7
            // 
            scalarValueCondition7.ColumnNumber = 3;
            scalarValueCondition7.Enabled = true;
            scalarValueCondition7.ExpectedValue = "1";
            scalarValueCondition7.Name = "scalarValueCondition7";
            scalarValueCondition7.NullExpected = false;
            scalarValueCondition7.ResultSet = 1;
            scalarValueCondition7.RowNumber = 1;
            // 
            // scalarValueCondition8
            // 
            scalarValueCondition8.ColumnNumber = 4;
            scalarValueCondition8.Enabled = true;
            scalarValueCondition8.ExpectedValue = "1";
            scalarValueCondition8.Name = "scalarValueCondition8";
            scalarValueCondition8.NullExpected = false;
            scalarValueCondition8.ResultSet = 1;
            scalarValueCondition8.RowNumber = 1;
            // 
            // scalarValueCondition9
            // 
            scalarValueCondition9.ColumnNumber = 5;
            scalarValueCondition9.Enabled = true;
            scalarValueCondition9.ExpectedValue = "1";
            scalarValueCondition9.Name = "scalarValueCondition9";
            scalarValueCondition9.NullExpected = false;
            scalarValueCondition9.ResultSet = 1;
            scalarValueCondition9.RowNumber = 1;
            // 
            // EMPTY_Values_Reset_Email_And_Password_TestAction
            // 
            EMPTY_Values_Reset_Email_And_Password_TestAction.Conditions.Add(scalarValueCondition10);
            EMPTY_Values_Reset_Email_And_Password_TestAction.Conditions.Add(scalarValueCondition11);
            resources.ApplyResources(EMPTY_Values_Reset_Email_And_Password_TestAction, "EMPTY_Values_Reset_Email_And_Password_TestAction");
            // 
            // scalarValueCondition10
            // 
            scalarValueCondition10.ColumnNumber = 5;
            scalarValueCondition10.Enabled = true;
            scalarValueCondition10.ExpectedValue = null;
            scalarValueCondition10.Name = "scalarValueCondition10";
            scalarValueCondition10.NullExpected = true;
            scalarValueCondition10.ResultSet = 1;
            scalarValueCondition10.RowNumber = 1;
            // 
            // scalarValueCondition11
            // 
            scalarValueCondition11.ColumnNumber = 6;
            scalarValueCondition11.Enabled = true;
            scalarValueCondition11.ExpectedValue = "False";
            scalarValueCondition11.Name = "scalarValueCondition11";
            scalarValueCondition11.NullExpected = false;
            scalarValueCondition11.ResultSet = 1;
            scalarValueCondition11.RowNumber = 1;
            // 
            // EMPTY_Values_Reset_Email_And_Password_PretestAction
            // 
            resources.ApplyResources(EMPTY_Values_Reset_Email_And_Password_PretestAction, "EMPTY_Values_Reset_Email_And_Password_PretestAction");
            // 
            // NULL_Values_Keeps_Same_PretestAction
            // 
            resources.ApplyResources(NULL_Values_Keeps_Same_PretestAction, "NULL_Values_Keeps_Same_PretestAction");
            // 
            // Update_Password_Set_Password_TestAction
            // 
            Update_Password_Set_Password_TestAction.Conditions.Add(scalarValueCondition12);
            resources.ApplyResources(Update_Password_Set_Password_TestAction, "Update_Password_Set_Password_TestAction");
            // 
            // scalarValueCondition12
            // 
            scalarValueCondition12.ColumnNumber = 6;
            scalarValueCondition12.Enabled = true;
            scalarValueCondition12.ExpectedValue = "True";
            scalarValueCondition12.Name = "scalarValueCondition12";
            scalarValueCondition12.NullExpected = false;
            scalarValueCondition12.ResultSet = 1;
            scalarValueCondition12.RowNumber = 1;
            // 
            // Update_Password_Set_Password_PretestAction
            // 
            resources.ApplyResources(Update_Password_Set_Password_PretestAction, "Update_Password_Set_Password_PretestAction");
            // 
            // Error_FirstName_EMPTY_TestAction
            // 
            Error_FirstName_EMPTY_TestAction.Conditions.Add(inconclusiveCondition1);
            resources.ApplyResources(Error_FirstName_EMPTY_TestAction, "Error_FirstName_EMPTY_TestAction");
            // 
            // inconclusiveCondition1
            // 
            inconclusiveCondition1.Enabled = true;
            inconclusiveCondition1.Name = "inconclusiveCondition1";
            // 
            // Error_LastName_EMPTY_TestAction
            // 
            Error_LastName_EMPTY_TestAction.Conditions.Add(inconclusiveCondition2);
            resources.ApplyResources(Error_LastName_EMPTY_TestAction, "Error_LastName_EMPTY_TestAction");
            // 
            // inconclusiveCondition2
            // 
            inconclusiveCondition2.Enabled = true;
            inconclusiveCondition2.Name = "inconclusiveCondition2";
            // 
            // Error_Unknown_Operator_TestAction
            // 
            Error_Unknown_Operator_TestAction.Conditions.Add(inconclusiveCondition3);
            resources.ApplyResources(Error_Unknown_Operator_TestAction, "Error_Unknown_Operator_TestAction");
            // 
            // inconclusiveCondition3
            // 
            inconclusiveCondition3.Enabled = true;
            inconclusiveCondition3.Name = "inconclusiveCondition3";
            // 
            // Update_All_FieldsData
            // 
            this.Update_All_FieldsData.PosttestAction = null;
            this.Update_All_FieldsData.PretestAction = Update_All_Fields_PretestAction;
            this.Update_All_FieldsData.TestAction = Update_All_Fields_TestAction;
            // 
            // NULL_Values_Keeps_SameData
            // 
            this.NULL_Values_Keeps_SameData.PosttestAction = null;
            this.NULL_Values_Keeps_SameData.PretestAction = NULL_Values_Keeps_Same_PretestAction;
            this.NULL_Values_Keeps_SameData.TestAction = NULL_Values_Keeps_Same_TestAction;
            // 
            // EMPTY_Values_Reset_Email_And_PasswordData
            // 
            this.EMPTY_Values_Reset_Email_And_PasswordData.PosttestAction = null;
            this.EMPTY_Values_Reset_Email_And_PasswordData.PretestAction = EMPTY_Values_Reset_Email_And_Password_PretestAction;
            this.EMPTY_Values_Reset_Email_And_PasswordData.TestAction = EMPTY_Values_Reset_Email_And_Password_TestAction;
            // 
            // Update_Password_Set_PasswordData
            // 
            this.Update_Password_Set_PasswordData.PosttestAction = null;
            this.Update_Password_Set_PasswordData.PretestAction = Update_Password_Set_Password_PretestAction;
            this.Update_Password_Set_PasswordData.TestAction = Update_Password_Set_Password_TestAction;
            // 
            // Error_FirstName_EMPTYData
            // 
            this.Error_FirstName_EMPTYData.PosttestAction = null;
            this.Error_FirstName_EMPTYData.PretestAction = Error_FirstName_EMPTY_PretestAction;
            this.Error_FirstName_EMPTYData.TestAction = Error_FirstName_EMPTY_TestAction;
            // 
            // Error_LastName_EMPTYData
            // 
            this.Error_LastName_EMPTYData.PosttestAction = null;
            this.Error_LastName_EMPTYData.PretestAction = Error_LastName_EMPTY_PretestAction;
            this.Error_LastName_EMPTYData.TestAction = Error_LastName_EMPTY_TestAction;
            // 
            // Error_Unknown_OperatorData
            // 
            this.Error_Unknown_OperatorData.PosttestAction = null;
            this.Error_Unknown_OperatorData.PretestAction = null;
            this.Error_Unknown_OperatorData.TestAction = Error_Unknown_Operator_TestAction;
            // 
            // Error_FirstName_EMPTY_PretestAction
            // 
            resources.ApplyResources(Error_FirstName_EMPTY_PretestAction, "Error_FirstName_EMPTY_PretestAction");
            // 
            // Error_LastName_EMPTY_PretestAction
            // 
            resources.ApplyResources(Error_LastName_EMPTY_PretestAction, "Error_LastName_EMPTY_PretestAction");
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion

        [TestMethod()]
        [TestCategory("Administration.Operator")]
        public void Update_All_Fields()
        {
            SqlDatabaseTestActions testActions = this.Update_All_FieldsData;
            // Exécuter le script de prétest
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Exécution du script prétest...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Exécuter le script de test
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Exécution du script test...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Exécuter le script de post-test
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Exécution du script post-test...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        [TestCategory("Administration.Operator")]
        public void NULL_Values_Keeps_Same()
        {
            SqlDatabaseTestActions testActions = this.NULL_Values_Keeps_SameData;
            // Exécuter le script de prétest
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Exécution du script prétest...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Exécuter le script de test
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Exécution du script test...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Exécuter le script de post-test
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Exécution du script post-test...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        [TestCategory("Administration.Operator")]
        public void EMPTY_Values_Reset_Email_And_Password()
        {
            SqlDatabaseTestActions testActions = this.EMPTY_Values_Reset_Email_And_PasswordData;
            // Exécuter le script de prétest
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Exécution du script prétest...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Exécuter le script de test
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Exécution du script test...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Exécuter le script de post-test
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Exécution du script post-test...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        [TestCategory("Administration.Operator")]
        public void Update_Password_Set_Password()
        {
            SqlDatabaseTestActions testActions = this.Update_Password_Set_PasswordData;
            // Exécuter le script de prétest
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Exécution du script prétest...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Exécuter le script de test
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Exécution du script test...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Exécuter le script de post-test
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Exécution du script post-test...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        [TestCategory("Administration.Operator")]
        [ExpectedSqlException(Severity = 16, State = 10)]
        public void Error_FirstName_EMPTY()
        {
            SqlDatabaseTestActions testActions = this.Error_FirstName_EMPTYData;
            // Exécuter le script de prétest
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Exécution du script prétest...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Exécuter le script de test
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Exécution du script test...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            catch (SqlException e)
            {
                Assert.AreEqual("FirstName cannot be EMPTY", e.Message);
                throw e;
            }
            finally
            {
                // Exécuter le script de post-test
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Exécution du script post-test...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        [TestCategory("Administration.Operator")]
        [ExpectedSqlException(Severity = 16, State = 11)]
        public void Error_LastName_EMPTY()
        {
            SqlDatabaseTestActions testActions = this.Error_LastName_EMPTYData;
            // Exécuter le script de prétest
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Exécution du script prétest...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Exécuter le script de test
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Exécution du script test...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            catch (SqlException e)
            {
                Assert.AreEqual("LastName cannot be EMPTY", e.Message);
                throw e;
            }
            finally
            {
                // Exécuter le script de post-test
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Exécution du script post-test...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        [TestCategory("Administration.Operator")]
        [ExpectedSqlException(Severity = 16, State = 12)]
        public void Error_Unknown_Operator()
        {
            SqlDatabaseTestActions testActions = this.Error_Unknown_OperatorData;
            // Exécuter le script de prétest
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Exécution du script prétest...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Exécuter le script de test
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Exécution du script test...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            catch (SqlException e)
            {
                Assert.IsTrue(Regex.IsMatch(e.Message, @"^Operator ""-?[0-9]+"" does no longer exist$"), e.Message);
                throw e;
            }
            finally
            {
                // Exécuter le script de post-test
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Exécution du script post-test...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }

        private SqlDatabaseTestActions Update_All_FieldsData;
        private SqlDatabaseTestActions NULL_Values_Keeps_SameData;
        private SqlDatabaseTestActions EMPTY_Values_Reset_Email_And_PasswordData;
        private SqlDatabaseTestActions Update_Password_Set_PasswordData;
        private SqlDatabaseTestActions Error_FirstName_EMPTYData;
        private SqlDatabaseTestActions Error_LastName_EMPTYData;
        private SqlDatabaseTestActions Error_Unknown_OperatorData;
    }
}
