using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

using DepartamentoDeEstadoData.DataAccess;

namespace DepartamentoDeEstadoData
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DeptEstadoData : System.Web.Services.WebService
    {

        [WebMethod]
        public DataTable GetCorpClassesByYear(int filterYear)
        {
            try
            {
                return DepartamentoEstadoData.GetCorpClassesByYear(filterYear);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [WebMethod]
        public DataTable GetCorpClassesByYearSeries()
        {
            try
            {
                return DepartamentoEstadoData.GetCorpClassesByYearSeries();
            }
            catch (Exception)
            {
                throw;
            }
        }

        [WebMethod]
        public DataTable GetCorpJurisdictionsByYear(int filterYear)
        {
            try
            {
                return DepartamentoEstadoData.GetCorpJurisdictionsByYear(filterYear);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [WebMethod]
        public DataTable GetCorpOrganizationTypesByYear(int filterYear)
        {
            try
            {
                return DepartamentoEstadoData.GetCorpOrganizationTypesByYear(filterYear);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [WebMethod]
        public DataTable GetCorpOrganizationTypesByYearSeries()
        {
            try
            {
                return DepartamentoEstadoData.GetCorpOrganizationTypesByYearSeries();
            }
            catch (Exception)
            {
                throw;
            }
        }

        [WebMethod]
        public DataTable GetCorpTypesByYear(int filterYear)
        {
            try
            {
                return DepartamentoEstadoData.GetCorpTypesByYear(filterYear);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}