﻿// <copyright file="IndiGestureRecognizerBase.cs" company="David Strickland">
//     Copyright (c) David Strickland. The MIT License (MIT)
// </copyright>

namespace IndiXam.Forms.Controls.GestureRecognizers
{
    using System;
    using System.ComponentModel;
    using Xamarin.Forms;

    /// <summary>
    /// Base Class for the IndiGestureRecognizers Implements IIndiGestureRecognizer to 
    /// provide default implementation for all Recognizers
    ///  the shared properties and events used in all recognizers
    /// </summary>
    public class IndiGestureRecognizerBase : IIndiGestureRecognizer
    {
        /// <summary>
        /// Location Property backing field;
        /// </summary>
        private Point location;

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="IndiXam.Forms.Controls.GestureRecognizers.IndiGestureRecognizerBase"/> class.
        /// </summary>
        public IndiGestureRecognizerBase()
        {
        }

        #region INotifyPropertyChanged implementation
        /// <summary>
        /// Pointless event required by IGestureRecognizer
        /// </summary>
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        #endregion

        /// <summary>
        /// Occurs when activated.
        /// </summary>
        public event EventHandler Activated;

        /// <summary>
        /// Gets or sets Location where the gesture Occurred in the case of motions this is equal to the start.
        /// </summary>
        /// <value>The location.</value>
        public Point Location 
        { 
            get 
            { 
                return this.location; 
            }

            set
            {
                this.location = value;
                this.OnPropertyChanged("Location");
            }
        }

        /// <summary>
        /// Method fired when the specified Gesture occurs.
        /// </summary>
        public void OnActivated()
        {
            if (this.Activated != null) 
            {
                this.Activated(this, new EventArgs());
            }
        }

        /// <summary>
        /// Raises the property changed event.
        /// </summary>
        /// <param name="propertyName">Property name.</param>
        public void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
