﻿using System;
using Expressive.Expressions.Binary.Relational;
using Expressive.Operators;
using Expressive.Operators.Relational;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressive.Tests.Operators.Relational
{
    [TestClass]
    public class GreaterThanOrEqualOperatorTests : OperatorBaseTests
    {
        #region OperatorBaseTests Members

        internal override IOperator Operator => new GreaterThanOrEqualOperator();

        protected override Type ExpectedExpressionType => typeof(GreaterThanOrEqualExpression);

        internal override OperatorPrecedence ExpectedOperatorPrecedence => OperatorPrecedence.GreaterThanOrEqual;

        protected override string[] ExpectedTags => new[] { ">=" };

        #endregion
    }
}
