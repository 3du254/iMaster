using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraNavBar;
using DevExpress.XtraBars;
using DevExpress.Utils.Menu;
using Master.Forms;
using Master.ReportLaunchers;
using Master;
using System.Windows.Forms.Layout;
using DevExpress.XtraBars.Helpers;

namespace Master.Class
{
  public  class POSNavigator
    {
        Security _Security = new Security();
        public void LoadSystemAdministration(NavBarGroup NavBarGroup)
        {
          
            NavBarItem Companies = new NavBarItem("Companies");
            Companies.SmallImageIndex = 21;
            NavBarItem CostCenters = new NavBarItem("CostCenters");
            CostCenters.SmallImageIndex = 23;
            
            NavBarItem Currencies = new NavBarItem("Currencies");
            Currencies.SmallImageIndex = 32;
            NavBarItem UserCodeCategories = new NavBarItem("User Code Categories");
            UserCodeCategories.SmallImageIndex = 30;
            NavBarItem UserCodes = new NavBarItem("User Codes");
            UserCodes.SmallImageIndex = 31;
            NavBarItem Countries = new NavBarItem("Countries");
            Countries.SmallImageIndex = 33;
            NavBarItem Counties = new NavBarItem("Counties");
            Counties.SmallImageIndex = 34;
            NavBarItem Approver = new NavBarItem("Approvers");
            Approver.SmallImageIndex = 29;

            NavBarGroup.ItemLinks.Add(Companies);
            NavBarGroup.ItemLinks.Add(CostCenters);
            
            NavBarGroup.ItemLinks.Add(UserCodeCategories);
            NavBarGroup.ItemLinks.Add(UserCodes);
            NavBarGroup.ItemLinks.Add(Approver);
            NavBarGroup.ItemLinks.Add(Currencies);
            NavBarGroup.ItemLinks.Add(Countries);
            NavBarGroup.ItemLinks.Add(Counties);
        }
        public void LoadSecurity(NavBarGroup SecuritynavBarGroup)
        {
          
            NavBarItem CostCenterAccess = new NavBarItem("CostCenter Access");
            CostCenterAccess.SmallImageIndex = 24;
            NavBarItem SecurityGroups = new NavBarItem("Security Groups");
            SecurityGroups.SmallImageIndex = 25;
            NavBarItem Roles = new NavBarItem("Roles");
            Roles.SmallImageIndex = 26;
            NavBarItem UserRoles = new NavBarItem("User Roles");
            UserRoles.SmallImageIndex = 27;
            NavBarItem Users = new NavBarItem("Users");
            Users.SmallImageIndex = 22;
            NavBarItem UserGroups = new NavBarItem("User Groups");
            UserGroups.SmallImageIndex = 28;

            SecuritynavBarGroup.ItemLinks.Add(Users);
            SecuritynavBarGroup.ItemLinks.Add(Roles);
            SecuritynavBarGroup.ItemLinks.Add(UserRoles);
            SecuritynavBarGroup.ItemLinks.Add(SecurityGroups);
            SecuritynavBarGroup.ItemLinks.Add(UserGroups);
            SecuritynavBarGroup.ItemLinks.Add(CostCenterAccess);
        }
        public void LoadProcurements(NavBarGroup PuchaseNavBarGroup)
        {
           
            NavBarItem DirectInvoices = new NavBarItem("Direct Invoices");
            DirectInvoices.SmallImageIndex = 59;
            NavBarItem SupplierBalances = new NavBarItem("Supplier Balances");
            SupplierBalances.SmallImageIndex = 20;
            //NavBarItem AwardPo = new NavBarItem("Quotations Review");
            //AwardPo.SmallImageIndex = 20;
            NavBarItem SupplierPo = new NavBarItem("Purchase Orders");
            SupplierPo.SmallImageIndex = 5;
            //NavBarItem PurchaseOrders = new NavBarItem("Purchase Orders");
            //PurchaseOrders.SmallImageIndex = 47;
            NavBarItem POReceipts = new NavBarItem("PO Receipts");
            POReceipts.SmallImageIndex = 77;
            NavBarItem InvoiceMatching = new NavBarItem("Invoice Matching");
            InvoiceMatching.SmallImageIndex = 18;
            NavBarItem SupplierPayments = new NavBarItem("Supplier Payments");
            SupplierPayments.SmallImageIndex = 61;
            NavBarItem ReturnOutWards = new NavBarItem("Return OutWards");
            ReturnOutWards.SmallImageIndex = 76;
            //PuchaseNavBarGroup.Groups.Add(Procurement);
            //PuchaseNavBarGroup.ItemLinks.Add(Requisition);
            //PuchaseNavBarGroup.ItemLinks.Add(RequisitionReview);
            //PuchaseNavBarGroup.ItemLinks.Add(SupplierQuotations);
            //PuchaseNavBarGroup.ItemLinks.Add(AwardPo);
            PuchaseNavBarGroup.ItemLinks.Add(SupplierPo);
            PuchaseNavBarGroup.ItemLinks.Add(POReceipts);
            PuchaseNavBarGroup.ItemLinks.Add(InvoiceMatching);
            PuchaseNavBarGroup.ItemLinks.Add(DirectInvoices);
            PuchaseNavBarGroup.ItemLinks.Add(SupplierPayments);
            PuchaseNavBarGroup.ItemLinks.Add(ReturnOutWards);
            PuchaseNavBarGroup.ItemLinks.Add(SupplierBalances);
            
           

        }
        public void LoadInventoryManagement(NavBarGroup Inventory)
        {

            NavBarItem InventoryAdjustment = new NavBarItem("Inventory Adjustment");
            InventoryAdjustment.SmallImageIndex = 58;

            NavBarItem InventoryIssues = new NavBarItem("Inventory Issues");
            InventoryIssues.SmallImageIndex = 56;
           
            NavBarItem InventoryReceipts = new NavBarItem("Inventory Receipts");
            InventoryReceipts.SmallImageIndex = 55;
            
            NavBarItem InventoryTransfers = new NavBarItem("Inventory Transfers");
            InventoryTransfers.SmallImageIndex = 57;
            NavBarItem OpeningStock = new NavBarItem("Opening Stock");
            OpeningStock.SmallImageIndex = 20;


       
            Inventory.ItemLinks.Add(OpeningStock);
            Inventory.ItemLinks.Add(InventoryTransfers);
            Inventory.ItemLinks.Add(InventoryAdjustment);
            Inventory.ItemLinks.Add(InventoryIssues);
            Inventory.ItemLinks.Add(InventoryReceipts);
        }
        public void LoadSettings(NavBarGroup SetUps)
        {
            NavBarItem Categories = new NavBarItem("Categories");
            Categories.SmallImageIndex = 48;
            NavBarItem Suppliers = new NavBarItem("Suppliers");
            Suppliers.SmallImageIndex = 52;
            NavBarItem Customers = new NavBarItem("Customers");
            Customers.SmallImageIndex = 52;
            NavBarItem Items = new NavBarItem("Item Master");
            Items.SmallImageIndex = 46;
            NavBarItem Warehouses = new NavBarItem("Ware houses");
            Warehouses.SmallImageIndex = 53;
            NavBarItem UOM = new NavBarItem("UOM");
            UOM.SmallImageIndex = 49;
            NavBarItem UomConvertions = new NavBarItem("UOM Convertions");
            UomConvertions.SmallImageIndex = 50;
            NavBarItem PriceBands = new NavBarItem("Price Bands");
            PriceBands.SmallImageIndex = 54;
            NavBarItem CostPrice = new NavBarItem("Cost/Price Revision");
            CostPrice.SmallImageIndex = 51;
           
            SetUps.ItemLinks.Add(Items);
            SetUps.ItemLinks.Add(Categories);
            SetUps.ItemLinks.Add(UOM);
            SetUps.ItemLinks.Add(UomConvertions);
            SetUps.ItemLinks.Add(PriceBands);
            SetUps.ItemLinks.Add(CostPrice);
            SetUps.ItemLinks.Add(Warehouses);
            SetUps.ItemLinks.Add(Suppliers);
            SetUps.ItemLinks.Add(Customers);
          
        }
        public void LoadSALES(NavBarGroup Sales)
        {
            NavBarItem ReturnInwards = new NavBarItem("Return Inwards");
            ReturnInwards.SmallImageIndex = 19;
            NavBarItem CustomerRefunds = new NavBarItem("Customer Refunds");
            CustomerRefunds.SmallImageIndex = 17;
            NavBarItem Payouts = new NavBarItem("Payouts");
            Payouts.SmallImageIndex = 18;

            NavBarItem CashierChekin = new NavBarItem("Cashier Checkin");
            CashierChekin.SmallImageIndex = 37;

            NavBarItem SalesOrder = new NavBarItem("Sales Order");
            SalesOrder.SmallImageIndex = 15;

            NavBarItem CustomerReceipts = new NavBarItem("Customer Receipts");
            CustomerReceipts.SmallImageIndex = 17;

            Sales.ItemLinks.Add(CashierChekin);
            Sales.ItemLinks.Add(SalesOrder);
            Sales.ItemLinks.Add(CustomerReceipts);
            Sales.ItemLinks.Add(ReturnInwards);
            Sales.ItemLinks.Add(CustomerRefunds);
            Sales.ItemLinks.Add(Payouts);
        
        }
        public bool ValidateRight(string Right, string UserGroup, string SecurityModule)
        {
            try
            {
                _Security.SecurityModule = SecurityModule;
                _Security.Right = Right;
                _Security.Usergroup = UserGroup;
                return _Security.ValidatePrivilege();
            }
            catch (Exception)
            {

                return false;
            }
        }
        public void navBar_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            if (this.ValidateRight("View", AppConstant.UserID, e.Link.Caption))
            {

                switch (e.Link.Caption)
                {
                    case "Quotations Review":
                        frmPOaward _frmPOaward = new frmPOaward();
                        _frmPOaward.ShowDialog();
                        break;
                    case "Purchase Order":
                        frmPO _frmPO = new frmPO();
                        _frmPO.ShowDialog();
                        break;
                    case "Purchase Requisition":
                        frmRequisition _frmRequisition = new frmRequisition();
                        _frmRequisition.ShowDialog();
                        break;
                    case "Requisition Approval":
                        frmRequisitionReview _frmRequisitionReview = new frmRequisitionReview();
                        _frmRequisitionReview.ShowDialog();
                        break;
                    case "Supplier Quotations":
                        frmSupplierQuotations _frmSupplierQuotations = new frmSupplierQuotations();
                        _frmSupplierQuotations.ShowDialog();
                        break;
                    case "Requisitions":
                        requisitionslauncher _requisitionslauncher = new requisitionslauncher();
                        _requisitionslauncher.ShowDialog();
                        break;
                    case "Department Access":
                        frmDepartmentAccess _frmDepartmentAccess = new frmDepartmentAccess();
                        _frmDepartmentAccess.ShowDialog();
                        break;
                    case "Customers":
                        frmCustomers _frmCustomers = new frmCustomers();
                        _frmCustomers.ShowDialog();
                        break;
                    case "Return OutWards":
                        frmReturnOutwards _frmReturnOutwards = new frmReturnOutwards();
                        _frmReturnOutwards.ShowDialog();
                        break;
                    case "Sales Summary":
                        frmSalesSummary _frmSalesSummary = new frmSalesSummary();
                        _frmSalesSummary.ShowDialog();
                        break;
                    case "Stock Sheet Inquiry":
                        frmstockshettinquiry _frmstockshettinquiry = new frmstockshettinquiry();
                        _frmstockshettinquiry.ShowDialog();
                        break;
                    case "COA":
                        frmCOA _frmCOA = new frmCOA();
                        _frmCOA.ShowDialog();
                        break;
                    case "PO Reprint":
                        frmPoReprint _frmPoReprint = new frmPoReprint();
                        _frmPoReprint.ShowDialog();
                        break;
                    case "Customer Invoices":
                        frmCustomerInvoiceReprint _frmCustomerInvoiceReprint = new frmCustomerInvoiceReprint();
                        _frmCustomerInvoiceReprint.ShowDialog();
                        break;
                    case "Supplier Balances":
                        frmSupplierBalances _frmSupplierBalances = new frmSupplierBalances();
                        _frmSupplierBalances.ShowDialog();
                        break;
                    case "Supplier Balance":
                        frmrptSupplierBalance _frmrptSupplierBalance = new frmrptSupplierBalance();
                        _frmrptSupplierBalance.ShowDialog();
                        break;
                    case "Customer Balances":
                        frmCustomerBalanceLauncher _frmCustomerBalanceLauncher = new frmCustomerBalanceLauncher();
                        _frmCustomerBalanceLauncher.ShowDialog();
                        break;
                    case "Credit Notes":
                        frmcustomercreditnoteLauncher _frmcustomercreditnoteLauncher = new frmcustomercreditnoteLauncher();
                        _frmcustomercreditnoteLauncher.ShowDialog();
                        break;
                    case "Customer Refunds":
                        frmCustomerRefund _frmCustomerRefund = new frmCustomerRefund();
                        _frmCustomerRefund.ShowDialog();
                        break;
                    case "Payouts":
                        frmPayOuts _frmPayOuts = new frmPayOuts();
                        _frmPayOuts.ShowDialog();
                        break;
                    case "Return Inwards":
                        frmReturnInwards _frmReturnInwards = new frmReturnInwards();
                        _frmReturnInwards.ShowDialog();
                        break;
                    case "Supplier Payments":
                        frmSupplierPayment _frmSupplierPayment = new frmSupplierPayment();
                        _frmSupplierPayment.ShowDialog();
                        break;
                    case "Bank Accounts":
                        frmBankAccounts _frmBankAccounts = new frmBankAccounts();
                        _frmBankAccounts.ShowDialog();
                        break;
                    //case "Supplier Balance":
                    //    frmSupplierBalances _frmSupplierBalances = new frmSupplierBalances();
                    //    _frmSupplierBalances.ShowDialog();
                    //    break;
                    case "Direct Invoices":
                        frmDirectSupplierInvoice _frmDirectSupplierInvoice = new frmDirectSupplierInvoice();
                        _frmDirectSupplierInvoice.ShowDialog();
                        break;
                    case "Invoice Matching":
                        frmInvoiceMatching _frmInvoiceMatching = new frmInvoiceMatching();
                        _frmInvoiceMatching.ShowDialog();
                        break;
                    case "Recruitment Parameters":
                        frmHRRecruitmentParam _frmHRRecruitmentParam = new frmHRRecruitmentParam();
                        _frmHRRecruitmentParam.ShowDialog();
                        break;
                    case "Job Applications":
                        frmJobApplications _frmJobApplications = new frmJobApplications();
                        _frmJobApplications.ShowDialog();
                        break;
                    case "Job Description":
                        frmJobDescription _frmJobDescription = new frmJobDescription();
                        _frmJobDescription.ShowDialog();
                        break;
                    case "Job Requisition":
                        frmJobRequisition _frmJobRequisition = new frmJobRequisition();
                        _frmJobRequisition.ShowDialog();
                        break;
                    case "Job Appraisals":
                        frmJobAppraisals _frmJobAppraisals = new frmJobAppraisals();
                        _frmJobAppraisals.ShowDialog();
                        break;
                    case "Employeee information":
                        frmEmployeeMaster _frmEmployeeMaster = new frmEmployeeMaster();
                        _frmEmployeeMaster.ShowDialog();
                        break;
                    case "Distribution Orders":
                        frmDistributionOders _frmDistributionOders = new frmDistributionOders();
                        _frmDistributionOders.ShowDialog();
                        break;
                    case "Inventory Adjustment":
                        frmInventoryAdjustment _frmInventoryAdjustment = new frmInventoryAdjustment();
                        _frmInventoryAdjustment.ShowDialog();
                        break;
                    case "Inventory Transfers":
                        frmInventoryTransfer _frmInventoryTransfer = new frmInventoryTransfer();
                        _frmInventoryTransfer.ShowDialog();
                        break;
                    case "Inventory Issues":
                        frmInventoryIssues _frmInventoryIssues = new frmInventoryIssues();
                        _frmInventoryIssues.ShowDialog();
                        break;
                    case "Inventory Receipts":
                        frmInventoryReceipt _frmInventoryReceipt = new frmInventoryReceipt();
                        _frmInventoryReceipt.ShowDialog();
                        break;
                    case "Purchase Orders":
                        frmPurchaseOrder _frmPurchaseOrder = new frmPurchaseOrder();
                        _frmPurchaseOrder.ShowDialog();
                        break;
                    case "Ware houses":
                        frmWareHouses _frmWareHouses = new frmWareHouses();
                        _frmWareHouses.ShowDialog();
                        break;
                    case "Sales Order":
                        frmSalesOrder _frmSalesOrder = new frmSalesOrder();
                        _frmSalesOrder.ShowDialog();
                        break;
                    case "PO Receipts":
                        frmPOReceipt _frmPOReceipt = new frmPOReceipt();
                        _frmPOReceipt.ShowDialog();
                        break;
                    case "Opening Stock":
                        frmOpeningStock _frmOpeningStock = new frmOpeningStock();
                        _frmOpeningStock.ShowDialog();
                        break;
                    case "Exchange Rates":
                        frmExchangeRates _frmExchangeRates = new frmExchangeRates();
                        _frmExchangeRates.ShowDialog();
                        break;

                    case "Payroll Review":
                        frmPayrollReview _frmPayrollReview = new frmPayrollReview();
                        _frmPayrollReview.ShowDialog();
                        break;
                    case "Bank Branches":
                        frmBankBranches _frmBankBranches = new frmBankBranches();
                        _frmBankBranches.ShowDialog();
                        break;
                    case "Banks":
                        frmbanks _frmbanks = new frmbanks();
                        _frmbanks.ShowDialog();
                        break;
                    case "Payroll Processing":
                        frmPayroll _frmPayroll = new frmPayroll();
                        _frmPayroll.ShowDialog();
                        break;
                    case "Posting Periods":
                        frmPostingPeriods _frmPostingPeriods = new frmPostingPeriods();
                        _frmPostingPeriods.ShowDialog();
                        break;
                    case "Tax Rates":
                        frmTaxRates _frmTaxRates = new frmTaxRates();
                        _frmTaxRates.ShowDialog();
                        break;
                    case "Benefits & Deductions":
                        frmDBAs _frmDBAs = new frmDBAs();
                        _frmDBAs.ShowDialog();
                        break;
                    case "Approvers":
                        frmApprovers _frmApprovers = new frmApprovers();
                        _frmApprovers.ShowDialog();
                        break;
                    case "Commission Entry":
                        frmCommisionEntry _frmCommisionEntry = new frmCommisionEntry();
                        _frmCommisionEntry.ShowDialog();
                        break;
                    case "Commission Tax Rates":
                        frmCommisionRates _frmCommisionRates = new frmCommisionRates();
                        _frmCommisionRates.ShowDialog();
                        break;
                    case "Leave Management":
                        frmLeaveManagent _frmLeaveManagent = new frmLeaveManagent();
                        _frmLeaveManagent.ShowDialog();
                        break;
                    case "Leave Types":
                        frmLeaveTypes _frmLeaveTypes = new frmLeaveTypes();
                        _frmLeaveTypes.ShowDialog();
                        break;
                    case "NHIF Rates":
                        frmNHIFRates _frmNHIFRates = new frmNHIFRates();
                        _frmNHIFRates.ShowDialog();
                        break;
                    case "NSSF Rates":
                        frmNSSFRates _frmNSSFRates = new frmNSSFRates();
                        _frmNSSFRates.ShowDialog();
                        break;
                    case "Over Time":
                        frmOverTime _frmOverTime = new frmOverTime();
                        _frmOverTime.ShowDialog();
                        break;
                    case "Over Time Rates":
                        frmOverTimeRates _frmOverTimeRates = new frmOverTimeRates();
                        _frmOverTimeRates.ShowDialog();
                        break;
                    case "Salary Advance":
                        frmSalaryAdvance _frmSalaryAdvance = new frmSalaryAdvance();
                        _frmSalaryAdvance.ShowDialog();
                        break;
                    case "Tax Tables":
                        frmTaxTables _frmTaxTables = new frmTaxTables();
                        _frmTaxTables.ShowDialog();
                        break;
                    case "User Codes":
                        frmUserCodes _frmUserCodes = new frmUserCodes();
                        _frmUserCodes.ShowDialog();
                        break;
                    case "Companies":
                        frmCompanies _frmCompanies = new frmCompanies();
                        _frmCompanies.ShowDialog();
                        break;
                    case "User Code Categories":
                        frmUserCodeCategories _frmUserCodeCategories = new frmUserCodeCategories();
                        _frmUserCodeCategories.ShowDialog();
                        break;
                    case "CostCenters":
                        frmCostCenter _frmCostCenter = new frmCostCenter();
                        _frmCostCenter.ShowDialog();
                        break;
                    case "CostCenter Access":
                        frmCompanyCostCenterAccess _frmCompanyCostCenterAccess = new frmCompanyCostCenterAccess();
                        _frmCompanyCostCenterAccess.ShowDialog();
                        break;
                    case "Security Groups":
                        frmSecurityGroups _frmSecurityGroups = new frmSecurityGroups();
                        _frmSecurityGroups.ShowDialog();
                        break;
                    case "Roles":
                        frmRoles _frmRoles = new frmRoles();
                        _frmRoles.ShowDialog();
                        break;
                    case "User Roles":
                        frmUserRoles _frmUserRoles = new frmUserRoles();
                        _frmUserRoles.ShowDialog();
                        break;
                    case "Users":
                        frmUsers _frmUsers = new frmUsers();
                        _frmUsers.ShowDialog();
                        break;
                    case "User Groups":
                        frmUserGroups _frmUserGroups = new frmUserGroups();
                        _frmUserGroups.ShowDialog();
                        break;
                    case "Currencies":
                        frmCurrencies _frmCurrencies = new frmCurrencies();
                        _frmCurrencies.ShowDialog();
                        break;

                    case "Countries":
                        frmCountry _frmCountry = new frmCountry();
                        _frmCountry.ShowDialog();
                        break;
                    case "UOM Convertions":
                        frmUOMConversions _frmUOMConversions = new frmUOMConversions();
                        _frmUOMConversions.ShowDialog();
                        break;
                    case "Counties":
                        frmCounties _frmCounties = new frmCounties();
                        _frmCounties.ShowDialog();
                        break;
                    case "Beneficiaries":
                        frmBeneficiaries _frmBeneficiaries = new frmBeneficiaries();
                        _frmBeneficiaries.ShowDialog();
                        break;
                    case "Payroll Reversal":
                        frmPayrollReverse _frmPayrollReverse = new frmPayrollReverse();
                        _frmPayrollReverse.ShowDialog();
                        break;
                    case "KPIs":
                        frmKPIs _frmKPIs = new frmKPIs();
                        _frmKPIs.ShowDialog();
                        break;
                    case "KPIs Entry":
                        frmKPIEntry _frmKPIEntry = new frmKPIEntry();
                        _frmKPIEntry.ShowDialog();
                        break;
                    case "Absence Registration":
                        frmAbsenceRegistration _frmAbsenceRegistration = new frmAbsenceRegistration();
                        _frmAbsenceRegistration.ShowDialog();
                        break;
                    case "UOM":
                        frmUOM _frmUOM = new frmUOM();
                        _frmUOM.ShowDialog();
                        break;
                    case "Categories":
                        frmItemCategories _frmItemCategories = new frmItemCategories();
                        _frmItemCategories.ShowDialog();
                        break;
                    case "Suppliers":
                        Suppliers _Suppliers = new Suppliers();
                        _Suppliers.ShowDialog();
                        break;

                    case "Journal Entry":
                        frmJournalEntry _frmJournalEntry = new frmJournalEntry();
                        _frmJournalEntry.ShowDialog();
                        break;
                    case "Ledgers":
                        frmLedger1 _frmLedger1 = new frmLedger1();
                        _frmLedger1.ShowDialog();
                        break;
                    case "Item Master":
                        frmItems _frmItems = new frmItems();
                        _frmItems.ShowDialog();
                        break;
                    case "Petty Cash":
                        frmPettyCash _frmPettyCash = new frmPettyCash();
                        _frmPettyCash.ShowDialog();
                        break;
                    case "Cheque Books":
                        frmChequeBooks _frmChequeBooks = new frmChequeBooks();
                        _frmChequeBooks.ShowDialog();
                        break;
                    case "Cashier Checkin":
                        frmCashierCheckin _frmCashierCheckin = new frmCashierCheckin();
                        _frmCashierCheckin.ShowDialog();
                        break;
                    case "Price Bands":
                        frmPriceBands _frmPriceBands = new frmPriceBands();
                        _frmPriceBands.ShowDialog();
                        break;
                    case "Cost/Price Revision":
                        frmCostPriceRevisions _frmCostPriceRevisions = new frmCostPriceRevisions();
                        _frmCostPriceRevisions.ShowDialog();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                e.Link.Item.Dispose();
                MessageBox.Show("You have insufficient rights to access this page", "Privilege Violation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

       

            public void LoadTopMenus(RibbonControl iMaster)
        {


            RibbonPage pgActions = new RibbonPage("Home");
            pgActions.Name = "Home";
            RibbonPageGroup grpActions = new RibbonPageGroup("Purchase");
            RibbonPageGroup grpUsers = new RibbonPageGroup("Adminstration");
            RibbonPageGroup grpSales = new RibbonPageGroup("Sales");
            RibbonPageGroup grpSetups = new RibbonPageGroup("Setups");
            RibbonPageGroup grpReports = new RibbonPageGroup("Reports");

            BarButtonItem DirectInvoice = new BarButtonItem();
            iMaster.Items.Add(DirectInvoice);
            DirectInvoice.Caption = "Direct Purchase";
            DirectInvoice.LargeImageIndex = 13;
            DirectInvoice.Id = iMaster.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
                                                               // EmployeeInfo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            DirectInvoice.ItemClick += new ItemClickEventHandler(DirectInvoice_ItemClick);

            BarButtonItem rUsers = new BarButtonItem();
            iMaster.Items.Add(rUsers);
            rUsers.Caption = "Users";
            rUsers.LargeImageIndex = 9;
          //  rUsers.ImageIndex = 9;
            rUsers.Id = iMaster.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.
           // rUsers.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            rUsers.ItemClick += new ItemClickEventHandler(rUsers_ItemClick);

            BarButtonItem rUsersRoles = new BarButtonItem();
            iMaster.Items.Add(rUsersRoles);
            rUsersRoles.Caption = "Users Roles";
            rUsersRoles.LargeImageIndex = 10;
            rUsersRoles.Id = iMaster.Manager.GetNewItemId(); // rUsersRoles.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            rUsersRoles.ItemClick += new ItemClickEventHandler(rUsersRoles_ItemClick);

            BarButtonItem rRoles = new BarButtonItem();
            iMaster.Items.Add(rRoles);
            rRoles.Caption = "Roles";
            rRoles.LargeImageIndex = 21;
            rRoles.Id = iMaster.Manager.GetNewItemId(); // rUsersRoles.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            rRoles.ItemClick += new ItemClickEventHandler(rRoles_ItemClick);

            BarButtonItem rPOReceipt = new BarButtonItem();
            iMaster.Items.Add(rPOReceipt);
            rPOReceipt.Caption = "PO Receipt";
            rPOReceipt.LargeImageIndex = 15;
            rPOReceipt.Id = iMaster.Manager.GetNewItemId(); // EmployeeInfo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            rPOReceipt.ItemClick += new ItemClickEventHandler(rPOReceipt_ItemClick);

            BarButtonItem rSupplierPayment = new BarButtonItem();
            iMaster.Items.Add(rSupplierPayment);
            rSupplierPayment.Caption = "Supplier Payment";
            rSupplierPayment.LargeImageIndex = 12;
            rSupplierPayment.Id = iMaster.Manager.GetNewItemId(); // EmployeeInfo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            rSupplierPayment.ItemClick += new ItemClickEventHandler(rSupplierPayment_ItemClick);

            BarButtonItem rReturnOutwards = new BarButtonItem();
            iMaster.Items.Add(rReturnOutwards);
            rReturnOutwards.Caption = "Return Outwards";
            rReturnOutwards.LargeImageIndex = 14;
            rReturnOutwards.Id = iMaster.Manager.GetNewItemId();   // EmployeeInfo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            rReturnOutwards.ItemClick += new ItemClickEventHandler(rReturnOutwards_ItemClick);

            BarButtonItem rSalesOrder = new BarButtonItem();
            iMaster.Items.Add(rSalesOrder);
            rSalesOrder.Caption = "Sales Order";
            rSalesOrder.LargeImageIndex = 16;
            rSalesOrder.Id = iMaster.Manager.GetNewItemId();   // EmployeeInfo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            rSalesOrder.ItemClick += new ItemClickEventHandler(rSalesOrder_ItemClick);

            BarButtonItem rCustomerReceipt = new BarButtonItem();
            iMaster.Items.Add(rCustomerReceipt);
            rCustomerReceipt.Caption = "Customer Receipt";
            rCustomerReceipt.LargeImageIndex = 19;
            rCustomerReceipt.Id = iMaster.Manager.GetNewItemId();   // EmployeeInfo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            rCustomerReceipt.ItemClick += new ItemClickEventHandler(rCustomerReceipt_ItemClick);

            BarButtonItem rReturnInwards = new BarButtonItem();
            iMaster.Items.Add(rReturnInwards);
            rReturnInwards.Caption = "Return Inwards";
            rReturnInwards.LargeImageIndex = 18;
            rReturnInwards.Id = iMaster.Manager.GetNewItemId();   // EmployeeInfo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            rReturnInwards.ItemClick += new ItemClickEventHandler(rReturnInwards_ItemClick);

            BarButtonItem rCustomerRefunds = new BarButtonItem();
            iMaster.Items.Add(rCustomerRefunds);
            rCustomerRefunds.Caption = "Customer Refunds";
            rCustomerRefunds.LargeImageIndex = 17;
            rCustomerRefunds.Id = iMaster.Manager.GetNewItemId();   // EmployeeInfo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            rCustomerRefunds.ItemClick += new ItemClickEventHandler(rCustomerRefunds_ItemClick);

            BarButtonItem rCostRevision = new BarButtonItem();
            iMaster.Items.Add(rCostRevision);
            rCostRevision.Caption = "Cost/Price Revisions";
            rCostRevision.LargeImageIndex = 22;
            rCostRevision.Id = iMaster.Manager.GetNewItemId();   // EmployeeInfo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            rCostRevision.ItemClick += new ItemClickEventHandler(rCostRevision_ItemClick);

            BarButtonItem rSaleSummary = new BarButtonItem();
            iMaster.Items.Add(rSaleSummary);
            rSaleSummary.Caption = "Sales Summary";
            rSaleSummary.LargeImageIndex = 22;
            rSaleSummary.Id = iMaster.Manager.GetNewItemId();   // EmployeeInfo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            rSaleSummary.ItemClick += new ItemClickEventHandler(rSaleSummary_ItemClick);

            BarButtonItem rCustomerInvoices = new BarButtonItem();
            iMaster.Items.Add(rCustomerInvoices);
            rCustomerInvoices.Caption = "Customer Invoices";
            rCustomerInvoices.LargeImageIndex = 22;
            rCustomerInvoices.Id = iMaster.Manager.GetNewItemId();   // EmployeeInfo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            rCustomerInvoices.ItemClick += new ItemClickEventHandler(rCustomerInvoices_ItemClick);

            BarButtonItem rCustomerBalances = new BarButtonItem();
            iMaster.Items.Add(rCustomerBalances);
            rCustomerBalances.Caption = "Customer Balances";
            rCustomerBalances.LargeImageIndex = 22;
            rCustomerBalances.Id = iMaster.Manager.GetNewItemId();   // EmployeeInfo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            rCustomerBalances.ItemClick += new ItemClickEventHandler(rCustomerBalances_ItemClick);

            BarButtonItem rCreditNotes = new BarButtonItem();
            iMaster.Items.Add(rCreditNotes);
            rCreditNotes.Caption = "Credit Notes";
            rCreditNotes.LargeImageIndex = 22;
            rCreditNotes.Id = iMaster.Manager.GetNewItemId();   // EmployeeInfo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            rCreditNotes.ItemClick += new ItemClickEventHandler(rCreditNotes_ItemClick);

            BarSubItem Setups = new BarSubItem();
            iMaster.Items.Add(Setups);
            Setups.Caption = "Setups";
            Setups.LargeImageIndex = 25;
            Setups.Id = iMaster.Manager.GetNewItemId(); //Ensures correct runtime layout (de)serialization.

            BarButtonItem rItemMaster = new BarButtonItem();
            iMaster.Items.Add(rItemMaster);
            rItemMaster.Caption = "Item Master";
            rItemMaster.LargeImageIndex = 23;
            rItemMaster.Id = iMaster.Manager.GetNewItemId();   // EmployeeInfo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            rItemMaster.ItemClick += new ItemClickEventHandler(rItemMaster_ItemClick);

            BarButtonItem rCustomers = new BarButtonItem();
            iMaster.Items.Add(rCustomers);
            rCustomers.Caption = "Customers";
            rCustomers.ImageIndex = 15;
            Setups.AddItem(rCustomers);
            rCustomers.Id = iMaster.Manager.GetNewItemId();   // EmployeeInfo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            rCustomers.ItemClick += new ItemClickEventHandler(rCustomers_ItemClick);

            BarButtonItem rSuppliers = new BarButtonItem();
            iMaster.Items.Add(rSuppliers);
            rSuppliers.Caption = "Suppliers";
            rSuppliers.ImageIndex = 16;
            Setups.AddItem(rSuppliers);
            rSuppliers.Id = iMaster.Manager.GetNewItemId();   // EmployeeInfo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            rSuppliers.ItemClick += new ItemClickEventHandler(rSuppliers_ItemClick);

            BarButtonItem rCategory = new BarButtonItem();
            iMaster.Items.Add(rCategory);
            rCategory.Caption = "Categories";
            rCategory.ImageIndex = 19;
            Setups.AddItem(rCategory);
            rCategory.Id = iMaster.Manager.GetNewItemId();   // EmployeeInfo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            rCategory.ItemClick += new ItemClickEventHandler(rCategory_ItemClick);

            BarButtonItem rUOM = new BarButtonItem();
            iMaster.Items.Add(rUOM);
            rUOM.Caption = "UOM";
            rUOM.ImageIndex = 17;
            Setups.AddItem(rUOM);
            rUOM.Id = iMaster.Manager.GetNewItemId();   // EmployeeInfo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            rUOM.ItemClick += new ItemClickEventHandler(rUOM_ItemClick);

            BarButtonItem rUOMConversions = new BarButtonItem();
            iMaster.Items.Add(rUOMConversions);
            rUOMConversions.Caption = "UOM Conversions";
            rUOMConversions.ImageIndex = 18;
            Setups.AddItem(rUOMConversions);
            rUOMConversions.Id = iMaster.Manager.GetNewItemId();   // EmployeeInfo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            rUOMConversions.ItemClick += new ItemClickEventHandler(rUOMConversions_ItemClick);

            BarButtonItem rPriceBands = new BarButtonItem();
            iMaster.Items.Add(rPriceBands);
            rPriceBands.Caption = "Price Bands";
            rPriceBands.ImageIndex = 20;
            Setups.AddItem(rPriceBands);
            rPriceBands.Id = iMaster.Manager.GetNewItemId();   // EmployeeInfo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            rPriceBands.ItemClick += new ItemClickEventHandler(rPriceBands_ItemClick);

            BarButtonItem rWareHouses = new BarButtonItem();
            iMaster.Items.Add(rWareHouses);
            rWareHouses.Caption = "Warehouses";
            rWareHouses.ImageIndex = 21;
            Setups.AddItem(rWareHouses);
            rWareHouses.Id = iMaster.Manager.GetNewItemId();   // EmployeeInfo.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            rWareHouses.ItemClick += new ItemClickEventHandler(rWareHouses_ItemClick);


            RibbonPageGroup Skins = new RibbonPageGroup();
            RibbonGalleryBarItem rgbiSkins = new DevExpress.XtraBars.RibbonGalleryBarItem();

            rgbiSkins.Caption = "Skins";

            rgbiSkins.Gallery.AllowHoverImages = true;
            rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = true;
            rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = true;
            rgbiSkins.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            rgbiSkins.Gallery.ColumnCount = 4;
            rgbiSkins.Gallery.FixedHoverImageSize = false;
            rgbiSkins.Gallery.ImageSize = new System.Drawing.Size(32, 17);
            rgbiSkins.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top;
            rgbiSkins.Gallery.RowCount = 4;
            rgbiSkins.Id = 60;
            rgbiSkins.Name = "rgbiSkins";
            iMaster.Items.AddRange(new DevExpress.XtraBars.BarItem[] { rgbiSkins });
            Skins.ItemLinks.Add(rgbiSkins);
            Skins.Name = "skinsRibbonPageGroup";
            Skins.ShowCaptionButton = false;
            Skins.Text = "Skins";
            SkinHelper.InitSkinGallery(rgbiSkins, true);

           
            grpSetups.ItemLinks.AddRange(new BarItem[] { rItemMaster, rCostRevision,rCustomers,rSuppliers });
            grpSetups.ItemLinks.AddRange(Setups);
            grpSales.ItemLinks.AddRange(new BarItem[] { rSalesOrder, rCustomerReceipt, rReturnInwards, rCustomerRefunds });
            grpUsers.ItemLinks.AddRange(new BarItem[] { rUsers,rRoles, rUsersRoles });
            grpActions.ItemLinks.AddRange(new BarItem[] { DirectInvoice, rSupplierPayment, rReturnOutwards });
            grpReports.ItemLinks.AddRange(new BarItem[] { rSaleSummary,rCustomerInvoices,rCustomerBalances,rCreditNotes });

            pgActions.Groups.Add(grpUsers);
            pgActions.Groups.Add(grpSales);
            pgActions.Groups.Add(Skins);
            pgActions.Groups.Add(grpActions);
            pgActions.Groups.Add(grpSetups);
            pgActions.Groups.Add(grpReports);
            iMaster.Pages.Add(pgActions);


            
        }

        private void rCreditNotes_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmcustomercreditnoteLauncher _frmcustomercreditnoteLauncher = new frmcustomercreditnoteLauncher();
            _frmcustomercreditnoteLauncher.ShowDialog();
        }

        private void rCustomerBalances_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCustomerBalanceLauncher _frmCustomerBalanceLauncher = new frmCustomerBalanceLauncher();
            _frmCustomerBalanceLauncher.ShowDialog();
        }

        private void rCustomerInvoices_ItemClick(object sender, ItemClickEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void rSaleSummary_ItemClick(object sender, ItemClickEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void rWareHouses_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmWareHouses _frmWareHouses = new frmWareHouses();
            _frmWareHouses.ShowDialog();
        }

        private void rSuppliers_ItemClick(object sender, ItemClickEventArgs e)
        {
            Suppliers _Suppliers = new Suppliers();
            _Suppliers.ShowDialog();
        }

        private void rCustomers_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCustomers _frmCustomers = new frmCustomers();
            _frmCustomers.ShowDialog();
        }

        private void rPriceBands_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPriceBands _frmPriceBands = new frmPriceBands();
            _frmPriceBands.ShowDialog();
        }

        private void rUOMConversions_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmUOMConversions _frmUOMConversions = new frmUOMConversions();
            _frmUOMConversions.ShowDialog();
        }

        private void rUOM_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmUOM _frmUOM = new frmUOM();
            _frmUOM.ShowDialog();
        }

        private void rCostRevision_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCostPriceRevisions _frmCostPriceRevisions = new frmCostPriceRevisions();
            _frmCostPriceRevisions.ShowDialog();
        }

        private void rItemMaster_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmItems _frmItems = new frmItems();
            _frmItems.ShowDialog();
        }

        private void rCategory_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmItemCategories _frmItemCategories = new frmItemCategories();
            _frmItemCategories.ShowDialog();
        }

        private void rRoles_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmRoles _frmRoles = new frmRoles();
            _frmRoles.ShowDialog();
        }

        private void rReturnInwards_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmReturnInwards _frmReturnInwards = new frmReturnInwards();
            _frmReturnInwards.ShowDialog();
        }

        private void rPOReceipt_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPOReceipt _frmPOReceipt = new frmPOReceipt();
            _frmPOReceipt.ShowDialog();
        }

        private void rCustomerRefunds_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCustomerRefund _frmCustomerRefund = new frmCustomerRefund();
            _frmCustomerRefund.ShowDialog();
        }

        private void rCustomerReceipt_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCustomerPayment _frmCustomerPayment = new frmCustomerPayment();
            _frmCustomerPayment.ShowDialog();
        }

        private void rSalesOrder_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSalesOrder _frmSalesOrder = new frmSalesOrder();
            _frmSalesOrder.ShowDialog();
        }

        private void rReturnOutwards_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmReturnOutwards _frmReturnOutwards = new frmReturnOutwards();
            _frmReturnOutwards.ShowDialog();
        }

        private void rSupplierPayment_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSupplierPayment _frmSupplierPayment = new frmSupplierPayment();
            _frmSupplierPayment.ShowDialog();
        }

        private void DirectInvoice_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDirectSupplierInvoice _frmDirectSupplierInvoice = new frmDirectSupplierInvoice();
            _frmDirectSupplierInvoice.ShowDialog();
        }
            private void rUsersRoles_ItemClick(object sender, ItemClickEventArgs e)
    {
        frmUserRoles _frmUserRoles = new frmUserRoles();
        _frmUserRoles.ShowDialog();
    }

    private void rUsers_ItemClick(object sender, ItemClickEventArgs e)
    {
        try
        {
            frmUsers _frmUsers = new frmUsers();
            _frmUsers.ShowDialog();
        }
        catch (Exception)
        {

            
        }
    }

    }

}
