/*
 * M2Factor.PCL
 *
 * This file was automatically generated for 2Factor by APIMATIC BETA v2.0 on 02/18/2016
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SolvTech;

namespace SolvTech.Models
{
    public class VerifyOtpInputModel : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string status;
        private string details;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Status")]
        public string Status 
        { 
            get 
            {
                return this.status; 
            } 
            set 
            {
                this.status = value;
                onPropertyChanged("Status");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Details")]
        public string Details 
        { 
            get 
            {
                return this.details; 
            } 
            set 
            {
                this.details = value;
                onPropertyChanged("Details");
            }
        }

        /// <summary>
        /// Property changed event for observer pattern
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises event when a property is changed
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void onPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
} 