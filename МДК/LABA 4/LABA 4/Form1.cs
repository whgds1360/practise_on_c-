using Guna.UI2.WinForms;
using System.Text;

namespace LABA_4
{
    public partial class MainForm : Form
    {
        private StringBuilder _LabelPreResult = new StringBuilder();
        private StringBuilder _LabelText = new StringBuilder();
        private double _FirstNumber = 0;
        private double _LastNumber = 0;
        private string _SelectOperation;
        private int _CountOfCallFunction = 0;
        private double _FirstNumberLastValue = 0;
        private double _ResultLastOperation = 0;

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

            _LabelPreResult.Append($"{SendButton.Tag}");
            _UpdateLabelPreResult();
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

                        _LabelPreResult = new StringBuilder();
                        _UpdateLabelPreResult();

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
            if (_CountOfCallFunction == 1)
            {
                double.TryParse(_LabelText.ToString(), out _LastNumber);
                _LabelPreResult.Append(" =");
                _UpdateLabelPreResult();

                switch (_SelectOperation)
                {
                    case "/":
                        if (_LastNumber != 0)
                        {
                            _LabelText.Clear();
                            _ResultLastOperation = _FirstNumber / _LastNumber;
                            _LabelText.Append(_ResultLastOperation);
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
                        _ResultLastOperation = _FirstNumber + _LastNumber;
                        _LabelText.Append(_ResultLastOperation);
                        _UpdateLabelText();
                        break;

                    case "-":
                        _LabelText.Clear();
                        _ResultLastOperation = _FirstNumber - _LastNumber;
                        _LabelText.Append(_ResultLastOperation.ToString());
                        _UpdateLabelText();
                        break;

                    case "*":
                        _LabelText.Clear();
                        _ResultLastOperation = _FirstNumber * _LastNumber;
                        _LabelText.Append((_FirstNumber * _LastNumber).ToString());
                        _UpdateLabelText();
                        break;

                    default:
                        break;
                }

            }
            else
            {   
                if (!_LabelPreResult.ToString().Contains("="))
                {
                    _LabelPreResult.Append(" =");
                }

                double.TryParse(_LabelText.ToString(), out _FirstNumber);
                if (_FirstNumber == 0)
                {
                    _LabelPreResult.Remove(0, _ResultLastOperation.ToString().Length);
                    _LabelPreResult.Insert(0, _ResultLastOperation);
                    _UpdateLabelPreResult();
                }
                else
                {
                    _LabelPreResult.Remove(0, _ResultLastOperation.ToString().Length);
                    _LabelPreResult.Insert(0, _ResultLastOperation);
                    _UpdateLabelPreResult();
                }

                switch (_SelectOperation)
                {   
                    case "/":
                        if (_FirstNumber != 0)
                        {
                            _LabelText.Clear();
                            _LabelText.Append(_ResultLastOperation / _FirstNumber);
                            _UpdateLabelText();
                            _ResultLastOperation = _ResultLastOperation / _FirstNumber;
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
                        _LabelText.Append(_ResultLastOperation + _FirstNumber);
                        _UpdateLabelText();
                        _ResultLastOperation = _ResultLastOperation + _FirstNumber;
                        break;

                    case "-":
                        _LabelText.Clear();
                        _LabelText.Append(_ResultLastOperation - _FirstNumber);
                        _UpdateLabelText();
                        _ResultLastOperation = _ResultLastOperation - _FirstNumber;
                        break;

                    case "*":
                        _LabelText.Clear();
                        _LabelText.Append(_ResultLastOperation * _FirstNumber);
                        _UpdateLabelText();
                        _ResultLastOperation = _ResultLastOperation * _FirstNumber;
                        break;

                    default:
                        break;
                }
            }
        }

        private void _UpdateLabelPreResult()
        {
            LabelPreResult.Text = _LabelPreResult.ToString();
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
            if (_CountOfCallFunction == 0)
            {
                _LabelPreResult.Append($" {_SelectOperation} ");
                _UpdateLabelPreResult();

                double.TryParse(_LabelText.ToString(), out _FirstNumber);

                _LabelText.Clear();
                _UpdateLabelText();
            }
            else
            {
                _LabelPreResult.Clear();
                _LabelPreResult.Append($"{_ResultLastOperation} {_SelectOperation} ");
                _UpdateLabelPreResult();

                _LabelText.Clear();
                _UpdateLabelText();
            }
        }

        private void _CloseHandler(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}