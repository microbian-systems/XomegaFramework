﻿// Copyright (c) 2010-2013 Xomega.Net. All rights reserved.

using System.Windows;

namespace Xomega.Framework
{
    /// <summary>
    /// A static collection of dependency properties that are used by Xomega framework.
    /// Most of these properties must be set manually in XAML and are related to data properties
    /// and since they have to be prefixed by the containing class name the latter has been made
    /// a short most relevant word.
    /// </summary>
    public class Property
    {
        /// <summary>
        ///  Gets the data property name dependency property for the given framework element if any.
        /// </summary>
        /// <param name="obj">The framework element to get the dependency property of.</param>
        /// <returns>The data property name dependency property for the given framework element if any.</returns>
        public static string GetName(DependencyObject obj)
        {
            return (string)obj.GetValue(NameProperty);
        }

        /// <summary>
        ///  Sets a data property name dependency property on a framework element.
        /// </summary>
        /// <param name="obj">The framework element to set the dependency property on.</param>
        /// <param name="value">The data property name to set.</param>
        public static void SetName(DependencyObject obj, string value)
        {
            obj.SetValue(NameProperty, value);
        }

        /// <summary>
        /// A dependency property that sets the data property name on a framework element
        /// to point to the data property that it needs to be bound to.
        /// The best practice for a setting the data property name on a framework element
        /// is to use a constant string declared in the code instead of hard coding the
        /// property name in XAML. This way renaming a property can be much easier
        /// and the compiler will validate the data property name in XAML.
        /// </summary>
        public static readonly DependencyProperty NameProperty = DependencyProperty.RegisterAttached(
            "Name", typeof(string), typeof(Property), new PropertyMetadata(SetupBinding));

        /// <summary>
        ///  Gets the child object dependency property for the given framework element if any.
        /// </summary>
        /// <param name="obj">The framework element to get the dependency property of.</param>
        /// <returns>The child object dependency property for the given framework element if any.</returns>
        public static string GetChildObject(DependencyObject obj)
        {
            return (string)obj.GetValue(ChildObjectProperty);
        }

        /// <summary>
        ///  Sets a child object dependency property on a framework element.
        /// </summary>
        /// <param name="obj">The framework element to set the dependency property on.</param>
        /// <param name="value">The child object path to set.</param>
        public static void SetChildObject(DependencyObject obj, string value)
        {
            obj.SetValue(ChildObjectProperty, value);
        }

        /// <summary>
        /// A dependency property that sets a dot delimited path to the child data object on a framework element.
        /// This dependency property can be set only in conjunction with the data property name.
        /// It points to a child data object contained within the data context object of the element,
        /// from which a data property with the given name should be bound to this element.
        /// The best practice for setting the child object path on a framework element
        /// is to use a constant string declared in the code instead of hard coding the
        /// path in XAML. This way renaming child objects can be much easier
        /// and the compiler will validate the child object path in XAML.
        /// </summary>
        public static readonly DependencyProperty ChildObjectProperty = DependencyProperty.RegisterAttached(
            "ChildObject", typeof(string), typeof(Property),
#if SILVERLIGHT
            new PropertyMetadata(SetupBinding));
#else
            new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits, SetupBinding));
#endif

        /// <summary>
        /// A callback that is triggered when a data property name or a child object path
        /// are set on a framework element. It sets up a new data property binding on the element.
        /// </summary>
        /// <param name="d">The framework element.</param>
        /// <param name="e">Event arguments.</param>
        public static void SetupBinding(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // calling a static method DataPropertyBinding.IsBindable ensures that
            // the static constructor is called and all WPF bindings get registered
            if (DataPropertyBinding.IsBindable(d))
                DataPropertyBinding.Create(d);
        }

        /// <summary>
        /// Internal dependency property that stores the data property binding on the element.
        /// </summary>
        public static readonly DependencyProperty BindingProperty = DependencyProperty.RegisterAttached(
            "Binding", typeof(DataPropertyBinding), typeof(Property),
#if SILVERLIGHT
            new PropertyMetadata(null));
#else
            new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.Inherits));
#endif

        /// <summary>
        ///  Gets the Required dependency property for the given framework element if any.
        /// </summary>
        /// <param name="obj">The framework element to get the dependency property of.</param>
        /// <returns>The value of the Required dependency property for the given framework element if any.</returns>
        public static bool GetRequired(FrameworkElement obj)
        {
            return (bool)obj.GetValue(RequiredProperty);
        }

        /// <summary>
        ///  Sets a Required dependency property on a framework element.
        /// </summary>
        /// <param name="obj">The framework element to set the dependency property on.</param>
        /// <param name="value">The value of the required flag to set.</param>
        public static void SetRequired(FrameworkElement obj, bool value)
        {
            obj.SetValue(RequiredProperty, value);
        }

        /// <summary>
        /// A dependency property that stores the Required flag of the underlying data property
        /// on the framework element and the associated label so that they could be styled appropriately,
        /// e.g. make the label bold for a required field or had an asterisk at the end, etc.
        /// </summary>
        public static readonly DependencyProperty RequiredProperty = DependencyProperty.RegisterAttached(
            "Required", typeof(bool), typeof(Property), new PropertyMetadata(null));

        /// <summary>
        ///  Gets the label associated with the given framework element if any.
        /// </summary>
        /// <param name="obj">The framework element to get the label of.</param>
        /// <returns>The label associated with the given framework element if any.</returns>
        public static FrameworkElement GetLabel(FrameworkElement obj)
        {
            return (FrameworkElement)obj.GetValue(LabelProperty);
        }

        /// <summary>
        ///  Sets a label for the given framework element.
        /// </summary>
        /// <param name="obj">The framework element to set the label for.</param>
        /// <param name="value">The label element set for the given framework.</param>
        public static void SetLabel(FrameworkElement obj, FrameworkElement value)
        {
            obj.SetValue(LabelProperty, value);
        }

        /// <summary>
        /// A dependency property that stores a reference to the label associated with the current framework element.
        /// </summary>
        /// <remarks>Recreates the property binding when a label is being set since the the former uses the label.</remarks>
        public static readonly DependencyProperty LabelProperty = DependencyProperty.RegisterAttached(
            "Label", typeof(FrameworkElement), typeof(Property), new PropertyMetadata(SetupBinding));

        /// <summary>
        /// Additional dependency property that stores data property's validation errors as an ErrorList,
        /// which has additional information for each error such as severity etc.
        /// </summary>
        public static readonly DependencyProperty ValidationProperty = DependencyProperty.RegisterAttached(
            "Validation", typeof(ValidationResults), typeof(Property), new PropertyMetadata(null));

        /// <summary>
        /// A helper class that allows storing the validation results as an error list.
        /// It is needed as a workaround to manually trigger Silverlight validation.
        /// </summary>
        public class ValidationResults
        {
            /// <summary>
            /// A property that throws a validation exception when being set if there are validation errors.
            /// This is a workaround to manually trigger Silverlight validation by binding to this property
            /// so that the binding will be in error.
            /// </summary>
            public object Show
            {
                get { return null; }
                set
                {
#if SILVERLIGHT
                    if (Errors != null && Errors.HasErrors())
                        throw new System.ComponentModel.DataAnnotations.ValidationException(Errors.ErrorsText);
#endif
                }
            }

            /// <summary>
            /// A list of validation errors.
            /// </summary>
            public ErrorList Errors { get; set; }
        }
    }
}
