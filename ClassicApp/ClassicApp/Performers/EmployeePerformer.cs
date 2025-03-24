using ClassicApp.DataClasses;
using ClassicApp.ExteriorModels;
using ClassicApp.InteriorModels;

namespace ClassicApp.Performers
{
    public class EmployeePerformer
    {
        public GetEmployeeResponse DoAction(HttpContext context, string traceId, GetEmployeeRequest request)
        {
            try
            {
                #region Validate Request
                if (request.Id <= 0)
                    throw new Exception();
                if (string.IsNullOrEmpty(request.Name))
                    throw new Exception();
                #endregion

                #region Map Request
                GetEmployeeModel model = new GetEmployeeModel();
                model.Id = request.Id;
                model.Name = request.Name;
                model.Description = request.Description;
                #endregion

                var result = new EmployeeData().GetEmployeeFromDB(model);

                #region Map Response
                GetEmployeeResponse responseModel = new GetEmployeeResponse();
                responseModel.Id = result.Id;
                responseModel.Name = result.Name;
                responseModel.Description = result.Description;
                responseModel.Phone = result.Phone;
                responseModel.Designation = result.Designation;
                #endregion

                return responseModel;
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
