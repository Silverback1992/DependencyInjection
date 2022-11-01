using LowCouplingWithDI;
using LowCouplingWithDI.Interfaces;

IDataAccess DAL = new DataAccess();
IBusiness business = new Business(DAL);
var ui = new UserInterface(business);

ui.GetData();