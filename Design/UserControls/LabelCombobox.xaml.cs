using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Design.UserControls
{
    /// <summary>
    /// Interaction logic for LabelCombobox.xaml
    /// </summary>
    public partial class LabelCombobox : UserControl
    {
        #region CONSTANTS

        private const string MESSAGE_TITLE = "Label Combobox Error";

        #endregion CONSTANTS

        #region TYPES

        internal enum VisibleWarningType : byte
        {
            ALWAYS = 0,
            ONLYEMPTY,
            NEVER
        }

        #endregion TYPES

        #region DEPENDENCY PROPERTIES

        public static readonly DependencyProperty
              NameGroupProperty =
              DependencyProperty.Register(nameof(NameGroup),
              typeof(string), typeof(LabelCombobox),
              new PropertyMetadata(string.Empty, null));

        public static readonly DependencyProperty
            NameFieldProperty =
            DependencyProperty.Register(nameof(NameField),
            typeof(string), typeof(LabelCombobox),
            new PropertyMetadata(string.Empty, null));

        public static readonly DependencyProperty
            InfoMessageProperty =
            DependencyProperty.Register(nameof(InfoMessage),
            typeof(string), typeof(LabelCombobox),
            new PropertyMetadata(string.Empty, null));

        public static readonly DependencyProperty
            SelectedProperty =
            DependencyProperty.Register(nameof(Selected),
            typeof(IComboboxItem), typeof(LabelCombobox),
            new PropertyMetadata(null));

        public static readonly DependencyProperty
            ListComboboxProperty =
            DependencyProperty.Register(nameof(ListCombobox),
            typeof(List<IComboboxItem>), typeof(LabelCombobox),
            new PropertyMetadata(null, null));

        public static readonly DependencyProperty
           IsAttibuteProperty =
           DependencyProperty.Register(nameof(IsAttibute),
           typeof(bool), typeof(LabelCombobox),
           new PropertyMetadata(true, new PropertyChangedCallback(OnIsAttibuteChanged)));

        #endregion DEPENDENCY PROPERTIES

        #region PROPERTIES

        public string NameGroup
        {
            private get => (string)GetValue(NameGroupProperty);
            set => SetValue(NameGroupProperty, value);
        }

        public string NameField
        {
            private get => (string)GetValue(NameFieldProperty);
            set => SetValue(NameFieldProperty, value);
        }

        public string InfoMessage
        {
            //get => (string)GetValue(TextWarningProperty);
            set => SetValue(InfoMessageProperty, value);
        }

        public IComboboxItem Selected
        {
            get => (IComboboxItem)GetValue(SelectedProperty);
            set => SetValue(SelectedProperty, value);
        }

        public List<IComboboxItem> ListCombobox
        {
            get => (List<IComboboxItem>)GetValue(ListComboboxProperty);
            set => SetValue(ListComboboxProperty, value);
        }

        public bool IsAttibute
        {
            get => (bool)GetValue(IsAttibuteProperty);
            set => SetValue(IsAttibuteProperty, value);
        }

        #endregion PROPERTIES

        #region CONSTRUCTORS

        public LabelCombobox()
        {
            InitializeComponent();
        }

        #endregion CONSTRUCTORS

        #region EVENTS

        private static void OnIsAttibuteChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is LabelCombobox labelCombobox)
            {
                labelCombobox.OnIsAttibuteChanged(e);
            }
        }

        private void OnIsAttibuteChanged(DependencyPropertyChangedEventArgs e)
        {
            FontWeight fontWeight;
            bool isAttribute;

            try
            {
                if (e.NewValue == null)
                {
                    return;
                }

                isAttribute = Convert.ToBoolean(e.NewValue);

                fontWeight = FontWeights.Black;
                if (!isAttribute)
                {
                    fontWeight = FontWeights.Normal;
                }

                _groupBox.FontWeight = fontWeight;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, MESSAGE_TITLE);
            }
        }

        #endregion EVENTS

        #region METHODS        

        #endregion METHODS       
    }
}
