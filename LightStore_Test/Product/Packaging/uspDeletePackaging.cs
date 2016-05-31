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
    public class uspDeletePackaging : SqlDatabaseTestClass
    {

        public uspDeletePackaging()
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction uspDeletePackaging_One_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uspDeletePackaging));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction testInitializeAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction uspDeletePackaging_One_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction uspDeletePackaging_All_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition5;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition6;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Throw_Error_When_ProductId_Does_Not_Exist_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction Throw_Error_When_PackagingId_Does_Not_Exist_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition2;
            this.uspDeletePackaging_OneData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.uspDeletePackaging_AllData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.Throw_Error_When_ProductId_Does_Not_ExistData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.Throw_Error_When_PackagingId_Does_Not_ExistData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            uspDeletePackaging_One_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            scalarValueCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            testInitializeAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            uspDeletePackaging_One_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            uspDeletePackaging_All_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            scalarValueCondition5 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            scalarValueCondition6 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Throw_Error_When_ProductId_Does_Not_Exist_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            Throw_Error_When_PackagingId_Does_Not_Exist_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            // 
            // uspDeletePackaging_One_TestAction
            // 
            uspDeletePackaging_One_TestAction.Conditions.Add(scalarValueCondition2);
            uspDeletePackaging_One_TestAction.Conditions.Add(scalarValueCondition3);
            resources.ApplyResources(uspDeletePackaging_One_TestAction, "uspDeletePackaging_One_TestAction");
            // 
            // scalarValueCondition2
            // 
            scalarValueCondition2.ColumnNumber = 1;
            scalarValueCondition2.Enabled = true;
            scalarValueCondition2.ExpectedValue = "1";
            scalarValueCondition2.Name = "scalarValueCondition2";
            scalarValueCondition2.NullExpected = false;
            scalarValueCondition2.ResultSet = 1;
            scalarValueCondition2.RowNumber = 1;
            // 
            // scalarValueCondition3
            // 
            scalarValueCondition3.ColumnNumber = 2;
            scalarValueCondition3.Enabled = true;
            scalarValueCondition3.ExpectedValue = "1";
            scalarValueCondition3.Name = "scalarValueCondition3";
            scalarValueCondition3.NullExpected = false;
            scalarValueCondition3.ResultSet = 1;
            scalarValueCondition3.RowNumber = 1;
            // 
            // testInitializeAction
            // 
            resources.ApplyResources(testInitializeAction, "testInitializeAction");
            // 
            // uspDeletePackaging_One_PretestAction
            // 
            resources.ApplyResources(uspDeletePackaging_One_PretestAction, "uspDeletePackaging_One_PretestAction");
            // 
            // uspDeletePackaging_All_TestAction
            // 
            uspDeletePackaging_All_TestAction.Conditions.Add(scalarValueCondition5);
            uspDeletePackaging_All_TestAction.Conditions.Add(scalarValueCondition6);
            resources.ApplyResources(uspDeletePackaging_All_TestAction, "uspDeletePackaging_All_TestAction");
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
            scalarValueCondition6.ExpectedValue = "0";
            scalarValueCondition6.Name = "scalarValueCondition6";
            scalarValueCondition6.NullExpected = false;
            scalarValueCondition6.ResultSet = 1;
            scalarValueCondition6.RowNumber = 1;
            // 
            // Throw_Error_When_ProductId_Does_Not_Exist_TestAction
            // 
            Throw_Error_When_ProductId_Does_Not_Exist_TestAction.Conditions.Add(inconclusiveCondition1);
            resources.ApplyResources(Throw_Error_When_ProductId_Does_Not_Exist_TestAction, "Throw_Error_When_ProductId_Does_Not_Exist_TestAction");
            // 
            // inconclusiveCondition1
            // 
            inconclusiveCondition1.Enabled = true;
            inconclusiveCondition1.Name = "inconclusiveCondition1";
            // 
            // Throw_Error_When_PackagingId_Does_Not_Exist_TestAction
            // 
            Throw_Error_When_PackagingId_Does_Not_Exist_TestAction.Conditions.Add(inconclusiveCondition2);
            resources.ApplyResources(Throw_Error_When_PackagingId_Does_Not_Exist_TestAction, "Throw_Error_When_PackagingId_Does_Not_Exist_TestAction");
            // 
            // inconclusiveCondition2
            // 
            inconclusiveCondition2.Enabled = true;
            inconclusiveCondition2.Name = "inconclusiveCondition2";
            // 
            // uspDeletePackaging_OneData
            // 
            this.uspDeletePackaging_OneData.PosttestAction = null;
            this.uspDeletePackaging_OneData.PretestAction = uspDeletePackaging_One_PretestAction;
            this.uspDeletePackaging_OneData.TestAction = uspDeletePackaging_One_TestAction;
            // 
            // uspDeletePackaging_AllData
            // 
            this.uspDeletePackaging_AllData.PosttestAction = null;
            this.uspDeletePackaging_AllData.PretestAction = null;
            this.uspDeletePackaging_AllData.TestAction = uspDeletePackaging_All_TestAction;
            // 
            // Throw_Error_When_ProductId_Does_Not_ExistData
            // 
            this.Throw_Error_When_ProductId_Does_Not_ExistData.PosttestAction = null;
            this.Throw_Error_When_ProductId_Does_Not_ExistData.PretestAction = null;
            this.Throw_Error_When_ProductId_Does_Not_ExistData.TestAction = Throw_Error_When_ProductId_Does_Not_Exist_TestAction;
            // 
            // Throw_Error_When_PackagingId_Does_Not_ExistData
            // 
            this.Throw_Error_When_PackagingId_Does_Not_ExistData.PosttestAction = null;
            this.Throw_Error_When_PackagingId_Does_Not_ExistData.PretestAction = null;
            this.Throw_Error_When_PackagingId_Does_Not_ExistData.TestAction = Throw_Error_When_PackagingId_Does_Not_Exist_TestAction;
            // 
            // uspDeletePackaging
            // 
            this.TestInitializeAction = testInitializeAction;
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
        public void uspDeletePackaging_One()
        {
            SqlDatabaseTestActions testActions = this.uspDeletePackaging_OneData;
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
        public void uspDeletePackaging_All()
        {
            SqlDatabaseTestActions testActions = this.uspDeletePackaging_AllData;
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
        [ExpectedSqlException(Severity = 16, State = 255)]
        public void Throw_Error_When_ProductId_Does_Not_Exist()
        {
            SqlDatabaseTestActions testActions = this.Throw_Error_When_ProductId_Does_Not_ExistData;
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
        [ExpectedSqlException(Severity = 16, State = 255)]
        public void Throw_Error_When_PackagingId_Does_Not_Exist()
        {
            SqlDatabaseTestActions testActions = this.Throw_Error_When_PackagingId_Does_Not_ExistData;
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
        
        private SqlDatabaseTestActions uspDeletePackaging_OneData;
        private SqlDatabaseTestActions uspDeletePackaging_AllData;
        private SqlDatabaseTestActions Throw_Error_When_ProductId_Does_Not_ExistData;
        private SqlDatabaseTestActions Throw_Error_When_PackagingId_Does_Not_ExistData;
    }
}
