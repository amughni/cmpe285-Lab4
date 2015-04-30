using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn1_Click(object sender, EventArgs e)
    {
        RecordExpression("1");
    }
    protected void btn2_Click(object sender, EventArgs e)
    {
        RecordExpression("2");
    }
    protected void btn3_Click(object sender, EventArgs e)
    {
        RecordExpression("3");
    }
    protected void btn4_Click(object sender, EventArgs e)
    {
        RecordExpression("4");
    }
    protected void btn5_Click(object sender, EventArgs e)
    {
        RecordExpression("5");
    }
    protected void btn6_Click(object sender, EventArgs e)
    {
        RecordExpression("6");
    }
    protected void btn7_Click(object sender, EventArgs e)
    {
        RecordExpression("7");
    }
    protected void btn8_Click(object sender, EventArgs e)
    {
        RecordExpression("8");
    }
    protected void btn9_Click(object sender, EventArgs e)
    {
        RecordExpression("9");
    }
    protected void btn0_Click(object sender, EventArgs e)
    {
        RecordExpression("0");
    }
    protected void btnDecimalPoint_Click(object sender, EventArgs e)
    {
        RecordExpression(".");
    }
    protected void btnEquals_Click(object sender, EventArgs e)
    {
        //Evaluate expression
        txtResult.Text = Evaluate(txtResult.Text);
    }
    protected void txtClear_Click(object sender, EventArgs e)
    {
        Reset();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        RecordExpression("+");
    }
    protected void btnSub_Click(object sender, EventArgs e)
    {
        RecordExpression("-");
    }
    protected void btnMultiply_Click(object sender, EventArgs e)
    {
        RecordExpression("*");

    }
    protected void btnDivide_Click(object sender, EventArgs e)
    {
        RecordExpression("/");
    }

    private void Reset()
    {
        txtResult.Text = String.Empty;
        lastKeyPressed = String.Empty;
    }

    private static string Evaluate(string expression)
    {
        try
        {
            var loDataTable = new DataTable();
            var loDataColumn = new DataColumn("Eval", typeof(double), expression);
            loDataTable.Columns.Add(loDataColumn);
            loDataTable.Rows.Add(0);
            
            return loDataTable.Rows[0]["Eval"].ToString();
        }
        catch (IndexOutOfRangeException e)
        {
            //If LoDataTable has no row at index 0
            return "Error evaluating the expression. Exception: " + e.Message;
        }
        catch (DivideByZeroException e)
        {
            //when a expression contains divide by zero
            return "Error evaluating the expression. Exception: " + e.Message;
        }
        catch (OverflowException e)
        {
            //when an arithmetic, casting, or conversion operation in a checked context results in an overflow
            return "Error evaluating the expression. Exception: " + e.Message;
        }
        catch (EvaluateException e)
        {
            //Caught when System.Data.DataColumn cannot be evaluated
            return "Error evaluating the expression. Exception: " + e.Message;
        }
        catch (FieldAccessException e)
        {
            //If invalid attempt to access a private or protected field inside a class
            return "Error evaluating the expression. Exception: " + e.Message;
        }
        catch (FormatException e)
        {
            //If data format is invalid 
            return "Error evaluating the expression. Exception: " + e.Message;
        }
        catch (InvalidCastException e)
        {
            //Thrown when invalid casting or conversion
            return "Error evaluating the expression. Exception: " + e.Message;
        }
        catch (InvalidExpressionException e)
        {
            //when you try to add a DataColumn that contains an invalid Expression to a DataColumnCollection
            return "Error evaluating the expression. Exception: " + e.Message;
        }
        catch (InvalidOperationException e)
        {
            //when a method call is invalid for the object's current state
            return "Error evaluating the expression. Exception: " + e.Message;
        }
        catch (Exception e)
        {
            //Any other exception will come here
            return "Error evaluating the expression. Exception: " + e.Message;
        }
    }

    private String lastKeyPressed;

    /// <summary>
    /// Records the key press and construct an expression
    /// </summary>
    /// <param name="keyValue"></param>
    private void RecordExpression(String keyValue)
    {
        //DO NOT ALLOW CONSECUTIVE NUMERIC OPERATORS
        if (!String.IsNullOrEmpty(lastKeyPressed))
        {
            if (IsNumericOperator(lastKeyPressed) && IsNumericOperator(keyValue))
            {
                return;
            }
        }

        //DO NOT ALLOW DUPLICATE DECIMAL ENTRIES
        if (keyValue.Equals(".") && txtResult.Text.Contains(keyValue))
            return;

        txtResult.Text += keyValue;
        lastKeyPressed = keyValue;
    }

    private Boolean IsNumericOperator(String val)
    {
        if (val.Equals("/") || val.Equals("*") || val.Equals("=") || val.Equals("+") || val.Equals("-"))
        {
            return true;
        }
        return false;
    }
}