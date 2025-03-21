﻿// Copyright (c) 2025 Xomega.Net. All rights reserved.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace Xomega.Framework.Properties
{
    /// <summary>
    /// An integer property for numbers of the <c>int</c> CLR type.
    /// </summary>
    public class IntegerProperty : DataProperty<int?>
    {
        /// <summary>
        /// Utility function to determine if the given property is based on one of the integer data types,
        /// since integer properties do not have the same integer base class.
        /// </summary>
        /// <param name="prop">The data property to check.</param>
        /// <returns>True if the property is one of the integer properties, false otherwise</returns>
        public static bool IsPropertyInteger(DataProperty prop) => 
            prop is BigIntegerProperty   || prop is IntegerProperty ||
            prop is SmallIntegerProperty || prop is TinyIntegerProperty;

        /// <summary>
        /// The minimum valid value for the property.
        /// </summary>
        public int MinimumValue { get; set; }

        /// <summary>
        /// The maximum valid value for the property.
        /// </summary>
        public int MaximumValue { get; set; }

        /// <summary>
        ///  Constructs an IntegerProperty with a given name and adds it to the parent data object under this name.
        /// </summary>
        /// <param name="parent">The parent data object to add the property to if applicable.</param>
        /// <param name="name">The property name that should be unique within the parent data object.</param>

        public IntegerProperty(DataObject parent, string name)
            : base(parent, name)
        {
            MinimumValue = int.MinValue;
            MaximumValue = int.MaxValue;

            Validator += ValidateInteger;
            Validator += ValidateMinimum;
            Validator += ValidateMaximum;
        }

        /// <inheritdoc/>>
        public override void CopyFrom(DataProperty p)
        {
            if (p is IntegerProperty intProperty)
            {
                MinimumValue = intProperty.MinimumValue;
                MaximumValue = intProperty.MaximumValue;
            }
            base.CopyFrom(p);
        }

        /// <summary>
        /// Overrides the base method to construct a list of non-Nullable int values
        /// for the Transport format.
        /// </summary>
        /// <param name="format">The format to create a new list for.</param>
        /// <returns>A new list for the given format.</returns>
        protected override IList CreateList(ValueFormat format)
        {
            return format == ValueFormat.Transport ? new List<int>() : base.CreateList(format);
        }

        /// <summary>
        /// Converts a single value to a given format. For typed formats
        /// this method tries to convert various types of values to a nullable int.
        /// </summary>
        /// <param name="value">A single value to convert to the given format.</param>
        /// <param name="format">The value format to convert the value to.</param>
        /// <returns>The value converted to the given format.</returns>
        protected override object ConvertValue(object value, ValueFormat format)
        {
            if (format.IsTyped())
            {
                if (value is int?) return value;
                if (value is int) return (int?)value;
                if (value is double d) return (int?)d;
                if (IsValueNull(value, format)) return null;
                if (int.TryParse(Convert.ToString(value), NumberStyles.Number, null, out int i)) return i;
                if (format == ValueFormat.Transport) return null;
            }
            return base.ConvertValue(value, format);
        }

        /// <summary>
        /// A validation function that checks if the value is an int and reports a validation error if not.
        /// </summary>
        /// <param name="dp">Data property being validated.</param>
        /// <param name="value">The value to validate.</param>
        /// <param name="row">The row in a list object or null for regular data objects.</param>
        public static void ValidateInteger(DataProperty dp, object value, DataRow row)
        {
            if (dp != null && !dp.IsValueNull(value, ValueFormat.Internal)
                && !(value is int) && !(value is short) && !(value is byte))
                dp.AddValidationError(row, Messages.Validation_IntegerFormat, dp);
        }

        /// <summary>
        /// A validation function that checks if the value is an int that is not less
        /// than the property minimum and reports a validation error if it is.
        /// </summary>
        /// <param name="dp">Data property being validated.</param>
        /// <param name="value">The value to validate.</param>
        /// <param name="row">The row in a list object or null for regular data objects.</param>
        public static void ValidateMinimum(DataProperty dp, object value, DataRow row)
        {
            if (dp is IntegerProperty idp && (value is int?) && ((int?)value).Value < idp.MinimumValue)
                dp.AddValidationError(row, Messages.Validation_NumberMinimum, dp, idp.MinimumValue);
        }

        /// <summary>
        /// A validation function that checks if the value is an int that is not greater
        /// than the property maximum and reports a validation error if it is.
        /// </summary>
        /// <param name="dp">Data property being validated.</param>
        /// <param name="value">The value to validate.</param>
        /// <param name="row">The row in a list object or null for regular data objects.</param>
        public static void ValidateMaximum(DataProperty dp, object value, DataRow row)
        {
            if (dp is IntegerProperty idp && (value is int?) && ((int?)value).Value > idp.MaximumValue)
                dp.AddValidationError(row, Messages.Validation_NumberMaximum, dp, idp.MaximumValue);
        }
    }

    /// <summary>
    /// An integer property for positive numbers only.
    /// </summary>
    public class PositiveIntegerProperty : IntegerProperty
    {
        /// <summary>
        ///  Constructs a PositiveIntegerProperty with a given name and adds it to the parent data object under this name.
        /// </summary>
        /// <param name="parent">The parent data object to add the property to if applicable.</param>
        /// <param name="name">The property name that should be unique within the parent data object.</param>
        public PositiveIntegerProperty(DataObject parent, string name)
            : base(parent, name)
        {
            MinimumValue = 1;
        }
    }

    /// <summary>
    /// An integer key property to distinguish keys from regular integers. Unlike for regular integers, 
    /// comparison operators other than equality may not be applicable to integer keys.
    /// </summary>
    public class IntegerKeyProperty : IntegerProperty
    {
        /// <summary>
        ///  Constructs a IntegerKeyProperty with a given name and adds it to the parent data object under this name.
        /// </summary>
        /// <param name="parent">The parent data object to add the property to if applicable.</param>
        /// <param name="name">The property name that should be unique within the parent data object.</param>

        public IntegerKeyProperty(DataObject parent, string name)
            : base(parent, name)
        {
        }
    }
}