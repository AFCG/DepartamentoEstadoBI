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
    public partial class Charts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindCorpClassesChart();
            BindOrganizationTypesChart();
            BindCorporationTypesChart(2012);
            BindJurisdictionTypesChart(2012);
        }

        private void BindJurisdictionTypesChart(int filterYear)
        {
            PieChartValue value;
            DEWSReference.DeptEstadoDataSoapClient DEWS = new DeptEstadoDataSoapClient();

            foreach (DataRow dRow in DEWS.GetCorpJurisdictionsByYear(filterYear).Rows)
            {
                value = new PieChartValue();
                value.Category = dRow["Jurisdiction"].ToString();
                value.Data = Convert.ToDecimal(dRow["CorpTotal"]);
                pcJurisdictionTypes.PieChartValues.Add(value);
            }
        }

        private void BindCorporationTypesChart(int filterYear)
        {
            PieChartValue value;
            DEWSReference.DeptEstadoDataSoapClient DEWS = new DeptEstadoDataSoapClient();

            foreach (DataRow dRow in DEWS.GetCorpTypesByYear(filterYear).Rows)
            {
                value = new PieChartValue();
                value.Category = dRow["CorpType"].ToString();
                value.Data = Convert.ToDecimal(dRow["CorpTotal"]);
                value.PieChartValueColor = dRow["CorpType"].ToString() == "For Profit" ? "#D94F4C" : "#518CD7";
                pcCorpTypes.PieChartValues.Add(value);
            }
        }

        private void BindOrganizationTypesChart()
        {
            BarChartSeries yearSeries;
            DEWSReference.DeptEstadoDataSoapClient DEWS = new DeptEstadoDataSoapClient();

            foreach (DataRow dRow in DEWS.GetCorpOrganizationTypesByYearSeries().Rows)
            {
                yearSeries = new BarChartSeries();
                yearSeries.Name = dRow["OrganizationFormType"].ToString();
                yearSeries.Data = new decimal[]
                    {
                        Convert.ToDecimal(dRow["CorpTotal2008"]), Convert.ToDecimal(dRow["CorpTotal2009"]),
                        Convert.ToDecimal(dRow["CorpTotal2010"]), Convert.ToDecimal(dRow["CorpTotal2011"]),
                        Convert.ToDecimal(dRow["CorpTotal2012"])
                    };

                bcCorpOrganizationTypes.Series.Add(yearSeries);
            }
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
                        Convert.ToDecimal(dRow["CorpTotal2008"]), Convert.ToDecimal(dRow["CorpTotal2009"]),
                        Convert.ToDecimal(dRow["CorpTotal2010"]), Convert.ToDecimal(dRow["CorpTotal2011"]),
                        Convert.ToDecimal(dRow["CorpTotal2012"])
                    };

                bcCorpClassesByYear.Series.Add(yearSeries);
            }
        }



    }
}