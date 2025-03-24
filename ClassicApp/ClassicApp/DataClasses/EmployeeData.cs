using ClassicApp.InteriorModels;

namespace ClassicApp.DataClasses
{
    public class EmployeeData
    {
        public GetEmployeeResponseModel GetEmployeeFromDB(GetEmployeeModel empModel)
        {
            #region map request
            GetEmployeeResponseModel model = new GetEmployeeResponseModel();
            model.Id = 1;
            model.Name = "Asif";
            model.Description = "Employee";
            model.Phone = "0354221545";
            model.Designation = "Employee";
            #endregion

            return model;
        }
    }
}
