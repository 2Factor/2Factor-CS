/*
 * M2Factor.PCL
 *
 * This file was automatically generated for 2Factor by APIMATIC BETA v2.0 on 02/18/2016
 */
using System;
using SolvTech.Controllers;

namespace SolvTech
{
    public partial class M2FactorClient
    {

        /// <summary>
        /// Singleton access to ADDONSERVICES controller
        /// </summary>
        public ADDONSERVICESController ADDONSERVICES
        {
            get
            {
                return ADDONSERVICESController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to SMSOTP controller
        /// </summary>
        public SMSOTPController SMSOTP
        {
            get
            {
                return SMSOTPController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to VOICEOTP controller
        /// </summary>
        public VOICEOTPController VOICEOTP
        {
            get
            {
                return VOICEOTPController.Instance;
            }
        }

        /// <summary>
        /// Client constructor
        /// </summary>
        public M2FactorClient()
        {
        }
    }
}