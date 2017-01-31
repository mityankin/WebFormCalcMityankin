using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormCalcMityankin
{
    public partial class Default : System.Web.UI.Page
    {
        private string _previousValue;
        private string _currentValue;
        private string _act;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PreviousValue"] != null)
            {
                _previousValue = Session["PreviousValue"].ToString(); 
            }
            if (Session["CurrentValue"] != null)
            {
                _currentValue = Session["CurrentValue"].ToString(); 
            }
            if (Session["Act"] != null)
            {
                _act = Session["Act"].ToString();
            }
            if (_previousValue == null && _currentValue == null && _act == null)
            {
                this.Result.Text = "";
            }
        }

          protected void Num_Clic(object sender, EventArgs e)
        {
            var b = (sender as Button);
            this.CalcHistory.Text = this.CalcHistory.Text + b.CommandArgument;
            Session["CurrentValue"] = (_currentValue != null) ? _currentValue + b.CommandArgument : b.CommandArgument;
        }

        protected void Nm0_Click(object sender, EventArgs e)
        {
            this.CalcHistory.Text = this.CalcHistory.Text + "0";
            
            Session["CurrentValue"] = (_currentValue != null) ? _currentValue + "0" : "0";
        }



        protected void Clear_Click(object sender, EventArgs e)
        {
            this.CalcHistory.Text = "";
            this.Result.Text = "";
            Session["CurrentValue"] = null;
            Session["Act"] = null;
            Session["PreviousValue"] = null;
        }

        protected void Multiply_Click(object sender, EventArgs e)
        {
            if(_currentValue != null)
            {
                this.CalcHistory.Text = this.CalcHistory.Text + "*";
                CalcAction();
                Session["Act"] = "multiply";
            }

        }

        protected void Divided_Click(object sender, EventArgs e)
        {
            if (_currentValue != null)
            {
                this.CalcHistory.Text = this.CalcHistory.Text + "/";
                CalcAction();
                Session["Act"] = "divided";
            }

        }

        protected void Minus_Click(object sender, EventArgs e)
        {
           
            if (_previousValue == null && _currentValue == null && _act == null)
            {
                this.CalcHistory.Text = this.CalcHistory.Text + "-";
                Session["CurrentValue"] =  "-";
            }
            else if(_currentValue!=null && !_currentValue.Equals("-"))
            {
                this.CalcHistory.Text = this.CalcHistory.Text + "-";
                CalcAction();
                Session["Act"] = "minus";
            }


        }

        protected void Add_Click(object sender, EventArgs e)
        {
            if (_currentValue != null)
            {
                this.CalcHistory.Text = this.CalcHistory.Text + "+";
                CalcAction();
                Session["Act"] = "plus";
            }

        }

        protected void Done_Click(object sender, EventArgs e)
        {
            CalcAction();
            this.CalcHistory.Text = "";
            Session["CurrentValue"] = null;
            Session["Act"] = null;
            Session["PreviousValue"] = null;
        }


        private void CalcAction()
        {
            if (_previousValue != null && _currentValue != null && _act != null)
            {
                string result = CalcValue(_previousValue, _currentValue);
                this.Result.Text = result;
                Session["CurrentValue"] = null;
                Session["PreviousValue"] = result;

            }
            else if (_currentValue != null && _previousValue == null)
            {
                Session["PreviousValue"] = _currentValue;
                Session["CurrentValue"] = null;
            }



        }

        private string CalcValue(string pre, string curr)
        {
            string returnValue = "";
            int result;
            try
            {
                int a = Int32.Parse(pre);
                int b = Int32.Parse(curr);
                switch (_act)
                {
                    case "multiply":
                        result = a * b;
                        returnValue = result.ToString();
                        break;
                    case "divided":
                        if (b != 0)
                        {
                            result = a / b;
                            returnValue = result.ToString();
                        }
                        else
                        {
                            returnValue = "Error";
                        }
                        break;
                    case "minus":
                        result = a - b;
                        returnValue = result.ToString();
                        break;
                    case "plus":
                        result = a + b;
                        returnValue = result.ToString();
                        break;

                }

            }
            catch(Exception e)
            {               
                returnValue = "Something went wrong";
            }

            return returnValue;
        }

    }
}