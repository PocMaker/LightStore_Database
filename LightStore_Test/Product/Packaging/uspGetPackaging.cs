using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LightStore_Test
{
    [TestClass()]
    public class uspGetPackaging : SqlDatabaseTestClass
    {

        public uspGetPackaging()
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction uspGetPackaging_Fom_Product_Id_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaCondition1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uspGetPackaging));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition notEmptyResultSetCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction uspGetPackaging_Fom_Product_Id_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction uspGetPackaging_Fom_Packaging_Id_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction uspGetPackaging_Fom_Packaging_Id_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Throw_Error_If_No_Parameter_Specified_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition1;
            this.uspGetPackaging_Fom_Product_IdData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.uspGetPackaging_Fom_Packaging_IdData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.Throw_Error_If_No_Parameter_SpecifiedData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            uspGetPackaging_Fom_Product_Id_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            expectedSchemaCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            notEmptyResultSetCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.NotEmptyResultSetCondition();
            scalarValueCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            uspGetPackaging_Fom_Product_Id_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            uspGetPackaging_Fom_Packaging_Id_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            scalarValueCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            uspGetPackaging_Fom_Packaging_Id_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Throw_Error_If_No_Parameter_Specified_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            // 
            // uspGetPackaging_Fom_Product_Id_TestAction
            // 
            uspGetPackaging_Fom_Product_Id_TestAction.Conditions.Add(expectedSchemaCondition1);
            uspGetPackaging_Fom_Product_Id_TestAction.Conditions.Add(notEmptyResultSetCondition1);
            uspGetPackaging_Fom_Product_Id_TestAction.Conditions.Add(scalarValueCondition1);
            resources.ApplyResources(uspGetPackaging_Fom_Product_Id_TestAction, "uspGetPackaging_Fom_Product_Id_TestAction");
            // 
            // expectedSchemaCondition1
            // 
            expectedSchemaCondition1.Enabled = true;
            expectedSchemaCondition1.Name = "expectedSchemaCondition1";
            resources.ApplyResources(expectedSchemaCondition1, "expectedSchemaCondition1");
            expectedSchemaCondition1.Verbose = false;
            // 
            // notEmptyResultSetCondition1
            // 
            notEmptyResultSetCondition1.Enabled = true;
            notEmptyResultSetCondition1.Name = "notEmptyResultSetCondition1";
            notEmptyResultSetCondition1.ResultSet = 1;
            // 
            // scalarValueCondition1
            // 
            scalarValueCondition1.ColumnNumber = 1;
            scalarValueCondition1.Enabled = true;
            scalarValueCondition1.ExpectedValue = "1";
            scalarValueCondition1.Name = "scalarValueCondition1";
            scalarValueCondition1.NullExpected = false;
            scalarValueCondition1.ResultSet = 2;
            scalarValueCondition1.RowNumber = 1;
            // 
            // uspGetPackaging_Fom_Product_Id_PretestAction
            // 
            resources.ApplyResources(uspGetPackaging_Fom_Product_Id_PretestAction, "uspGetPackaging_Fom_Product_Id_PretestAction");
            // 
            // uspGetPackaging_Fom_Packaging_Id_TestAction
            // 
            uspGetPackaging_Fom_Packaging_Id_TestAction.Conditions.Add(rowCountCondition1);
            uspGetPackaging_Fom_Packaging_Id_TestAction.Conditions.Add(scalarValueCondition2);
            resources.ApplyResources(uspGetPackaging_Fom_Packaging_Id_TestAction, "uspGetPackaging_Fom_Packaging_Id_TestAction");
            // 
            // rowCountCondition1
            // 
            rowCountCondition1.Enabled = true;
            rowCountCondition1.Name = "rowCountCondition1";
            rowCountCondition1.ResultSet = 1;
            rowCountCondition1.RowCount = 1;
            // 
            // scalarValueCondition2
            // 
            scalarValueCondition2.ColumnNumber = 1;
            scalarValueCondition2.Enabled = true;
            scalarValueCondition2.ExpectedValue = "1";
            scalarValueCondition2.Name = "scalarValueCondition2";
            scalarValueCondition2.NullExpected = false;
            scalarValueCondition2.ResultSet = 2;
            scalarValueCondition2.RowNumber = 1;
            // 
            // uspGetPackaging_Fom_Packaging_Id_PretestAction
            // 
            resources.ApplyResources(uspGetPackaging_Fom_Packaging_Id_PretestAction, "uspGetPackaging_Fom_Packaging_Id_PretestAction");
            // 
            // Throw_Error_If_No_Parameter_Specified_TestAction
            // 
            Throw_Error_If_No_Parameter_Specified_TestAction.Conditions.Add(inconclusiveCondition1);
            resources.ApplyResources(Throw_Error_If_No_Parameter_Specified_TestAction, "Throw_Error_If_No_Parameter_Specified_TestAction");
            // 
            // inconclusiveCondition1
            // 
            inconclusiveCondition1.Enabled = true;
            inconclusiveCondition1.Name = "inconclusiveCondition1";
            // 
            // uspGetPackaging_Fom_Product_IdData
            // 
            this.uspGetPackaging_Fom_Product_IdData.PosttestAction = null;
            this.uspGetPackaging_Fom_Product_IdData.PretestAction = uspGetPackaging_Fom_Product_Id_PretestAction;
            this.uspGetPackaging_Fom_Product_IdData.TestAction = uspGetPackaging_Fom_Product_Id_TestAction;
            // 
            // uspGetPackaging_Fom_Packaging_IdData
            // 
            this.uspGetPackaging_Fom_Packaging_IdData.PosttestAction = null;
            this.uspGetPackaging_Fom_Packaging_IdData.PretestAction = uspGetPackaging_Fom_Packaging_Id_PretestAction;
            this.uspGetPackaging_Fom_Packaging_IdData.TestAction = uspGetPackaging_Fom_Packaging_Id_TestAction;
            // 
            // Throw_Error_If_No_Parameter_SpecifiedData
            // 
            this.Throw_Error_If_No_Parameter_SpecifiedData.PosttestAction = null;
            this.Throw_Error_If_No_Parameter_SpecifiedData.PretestAction = null;
            this.Throw_Error_If_No_Parameter_SpecifiedData.TestAction = Throw_Error_If_No_Parameter_Specified_TestAction;
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
        public void uspGetPackaging_Fom_Product_Id()
        {
            SqlDatabaseTestActions testActions = this.uspGetPackaging_Fom_Product_IdData;
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
        public void uspGetPackaging_Fom_Packaging_Id()
        {
            SqlDatabaseTestActions testActions = this.uspGetPackaging_Fom_Packaging_IdData;
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
        [ExpectedSqlException(Severity = 16, State = 10)]
        public void Throw_Error_If_No_Parameter_Specified()
        {
            SqlDatabaseTestActions testActions = this.Throw_Error_If_No_Parameter_SpecifiedData;
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


        private SqlDatabaseTestActions uspGetPackaging_Fom_Product_IdData;
        private SqlDatabaseTestActions uspGetPackaging_Fom_Packaging_IdData;
        private SqlDatabaseTestActions Throw_Error_If_No_Parameter_SpecifiedData;
    }
}
