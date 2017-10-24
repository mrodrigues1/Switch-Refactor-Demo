using System;
using System.Collections.Generic;

namespace RefactorSwitchDemo
{
    public class Operation
    {
        [Flags]
        private enum OperationRepresentation
        {
            Add = '/',
            Subtraction = '-',
            Multiply = '*',
            Divide = '/'
        }

        private Dictionary<string, Action> OperationsMap = new Dictionary<string, Action>()
        {
            
        };

        private OperationRepresentation Representation { get; }

        private Operation(OperationRepresentation representation)
        {
            this.Representation = representation;
        }

        public static Operation Add() => new Operation(OperationRepresentation.Add);

        public static Operation Subtraction() => new Operation(OperationRepresentation.Subtraction);

        public static Operation Multiply() => new Operation(OperationRepresentation.Multiply);

        public static Operation Divide() => new Operation(OperationRepresentation.Divide);
    }
}