using System;
using System.Collections.Generic;

namespace Command
{
    class Command
    {
        public char _operator;
        public double _operand;

        public Command(char _operator, double _operand) 
        {
            this._operator = _operator;
            this._operand = _operand;
        }
    }

    interface ICommand
    {
        void Execute();
        void Undo();
    }

    class Calculator 
    {
        private List<Command> commands;
        private double current;
        private double temp;

        public Calculator() 
        {
            commands = new List<Command>();
            current = 0;
            temp = 0;
        }

        public void Action(char _operator, double _operand) 
        {
            temp = current;

            switch (_operator)
            {
                case '+': 
                    current += _operand;
                    break;
                case '-': 
                    current -= _operand;
                    break;
                case '/': 
                    current /= _operand;
                    break;
                case '*': 
                    current *= _operand;
                    break;
                default: 
                    throw new Exception("Calculator.Action._operator unresolved");
            }

            System.Console.WriteLine($"Current result: {temp}");
            System.Console.WriteLine($"{temp} {_operator} {_operand} = {current}\n");

            commands.Add(new Command(_operator, _operand));
        }
    }


    class CalculatorCommand : ICommand
    {
        private Calculator _calculator;
        private char _operator;
        private double _operand;

        public CalculatorCommand(Calculator _calculator, char _operator, double _operand)
        {
            this._calculator = _calculator;
            this._operator = _operator;
            this._operand = _operand;
        }

        public void Execute()
        {
            _calculator.Action(_operator, _operand);
        }

        public void Undo()
        {
            _calculator.Action(Undo(_operator), _operand);
        }

        public char getOperator() 
        { 
            return _operator; 
        }

        public double getOperand() 
        { 
            return _operand; 
        }

        private char Undo(char op)
        {
            switch (op)
            {
                case '+': 
                    return '-';
                case '-': 
                    return '+';
                case '*': 
                    return '/';
                case '/': 
                    return '*';
                default: 
                    throw new Exception("CalculatorCommand.Undo.op unresolved");
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            CalculatorCommand command1  = new CalculatorCommand(calculator, '-', 5);
            CalculatorCommand command2 = new CalculatorCommand(calculator, '+', 20);
            CalculatorCommand command3 = new CalculatorCommand(calculator, '/', 4);
            CalculatorCommand command4 = new CalculatorCommand(calculator, '*', 5);

            command1.Execute();
            command1.Undo();
            command2.Execute();
            command3.Execute();
            command3.Undo();
            command4.Execute();
        }
    }
}
