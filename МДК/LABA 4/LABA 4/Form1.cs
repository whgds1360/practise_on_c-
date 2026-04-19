using Guna.UI2.WinForms;
using System.Text;
using System.Text.RegularExpressions;

namespace LABA_4
{
    public partial class MainForm : Form
    {
        private StringBuilder _LabelText = new StringBuilder();
        private double _FirstNumber = 0;
        private double _LastNumber = 0;
        private string _SelectOperation;
        private int _CountOfCallFunction = 0;

        private readonly Dictionary<string, string> _ButtonOperations = new Dictionary<string, string>
        {
            ["ButtonSquare"] = "^",
            ["ButtonRoot"] = "$",
            ["ButtonDivision"] = "/",
            ["ButtonPlus"] = "+",
            ["ButtonMinus"] = "-",
            ["ButtonMultiplication"] = "*"
        };


        public MainForm()
        {
            InitializeComponent();
        }

        private void _ClickNumberButtonHandler(object sender, EventArgs e)
        {
            Guna2Button SendButton;

            //Сделал что бы точно исключить момент неправильной привязки
            if (sender != null && sender is Guna2Button)
            {
                SendButton = (Guna2Button)sender;
            }
            else
            {
                throw new ArgumentException("В клик пришло что-то не то!");
            }

            _LabelText.Append(SendButton.Tag);
            _UpdateLabelText();
        }

        private void _UpdateLabelText()
        {
            LabelOutput.Text = _LabelText.ToString();
        }

        private void _FormaterLabel(object sender, EventArgs e)
        {
            Guna2Button SendButton = (Guna2Button)sender;

            switch (SendButton.Name)
            {

                case "ButtonClearAll":
                    {
                        _LabelText = new StringBuilder();
                        _UpdateLabelText();

                        (_FirstNumber, _LastNumber) = (0, 0);

                        _NullingCount();

                        break;
                    }

                case "ButtonClear":
                    {   
                        if (_LabelText.Length != 0)
                        {
                            _LabelText = _LabelText.Remove(_LabelText.Length - 1, 1);
                            _UpdateLabelText();
                        }
                        break;
                    }
            }
        }

        private void _SelectOperationHandler(object sender, EventArgs e)
        {
            Guna2Button SendButton;

            if (sender != null && sender is Guna2Button)
            {
                SendButton = (Guna2Button)sender;
            }
            else
            {
                throw new ArgumentException("В клик пришло что-то не то!");
            }

            if (_ButtonOperations.TryGetValue(SendButton.Name, out _SelectOperation))
            {
                _PreparationExecute();
            }
            else
            {
                throw new ArgumentException("В словарь пришло чё то не то!");
            }

            switch (_SelectOperation)
            {
                case "^":
                    _LabelText.Clear();
                    _LabelText.Append((Math.Pow(_FirstNumber, 2)).ToString());
                    _UpdateLabelText();
                    break;

                case "$":
                    if (_FirstNumber < 0)
                    {
                        _LabelText.Clear();
                        _LabelText.Append("Error");
                        _UpdateLabelText();
                        break;
                    }
                    else
                    {
                        _LabelText.Clear();
                        _LabelText.Append((Math.Sqrt(_FirstNumber)).ToString());
                        _UpdateLabelText();
                        break;
                    }

                default: 
                    break;
            }
        }

        private void _ExecuteHandler(object sender, EventArgs e)
        {
            _CountOfCallFunction += 1;
            if (_CountOfCallFunction <= 1)
            {
                double.TryParse(_LabelText.ToString(), out _LastNumber);
            }
            else
            {
                double.TryParse(_LabelText.ToString(), out _FirstNumber);
            }

            switch (_SelectOperation)
            {
                case "/":
                    if (_LastNumber != 0)
                    {
                        _LabelText.Clear();
                        _LabelText.Append((_FirstNumber / _LastNumber).ToString());
                        _UpdateLabelText();
                    }
                    else
                    {
                        _LabelText.Clear(); 
                        _LabelText.Append("Error");
                        _UpdateLabelText();
                    }
                    break;

                case "+":
                    _LabelText.Clear();
                    _LabelText.Append((_FirstNumber + _LastNumber).ToString());
                    _UpdateLabelText();
                    break;

                case "-":
                    _LabelText.Clear();
                    _LabelText.Append((_FirstNumber - _LastNumber).ToString());
                    _UpdateLabelText();
                    break;

                case "*":
                    _LabelText.Clear();
                    _LabelText.Append((_FirstNumber * _LastNumber).ToString());
                    _UpdateLabelText();
                    break;

                default:
                    break;
            }
        }
        
        private void _NullingCount()
        {
            _CountOfCallFunction = 0;
        }

        private void _SeparatorHandler(object sender, EventArgs e)
        {
            _LabelText.Append(",");
            _UpdateLabelText();
        }

        private void _PreparationExecute()
        {
            double.TryParse(_LabelText.ToString(), out _FirstNumber);

            _LabelText.Clear();
            _UpdateLabelText();
        }

        private void _CloseHandler(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}