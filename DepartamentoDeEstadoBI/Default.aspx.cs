using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using AjaxControlToolkit;

using DepartamentoDeEstadoBI.DEWSReference;

namespace DepartamentoDeEstadoBI
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindCorpClassesChart();
        }

        private void BindCorpClassesChart()
        {
            BarChartSeries yearSeries;
            DEWSReference.DeptEstadoDataSoapClient DEWS = new DeptEstadoDataSoapClient();

            foreach (DataRow dRow in DEWS.GetCorpClassesByYearSeries().Rows)
            {
                yearSeries = new BarChartSeries(); 
                yearSeries.Name = dRow["CorpClass"].ToString();
                yearSeries.Data = new decimal[]
                    {
                        Convert.ToDecimal(dRow["CorpTotal2002"]), Convert.ToDecimal(dRow["CorpTotal2003"]),
                        Convert.ToDecimal(dRow["CorpTotal2004"]), Convert.ToDecimal(dRow["CorpTotal2005"]),
                        Convert.ToDecimal(dRow["CorpTotal2006"]), Convert.ToDecimal(dRow["CorpTotal2007"]),
                        Convert.ToDecimal(dRow["CorpTotal2008"]), Convert.ToDecimal(dRow["CorpTotal2009"]),
                        Convert.ToDecimal(dRow["CorpTotal2010"]), Convert.ToDecimal(dRow["CorpTotal2011"]),
                        Convert.ToDecimal(dRow["CorpTotal2012"])
                    };

                bcCorpClassesByYear.Series.Add(yearSeries);
            }

            //bcCorpClassesByYear.Series.Add();

        }
    }
}