﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLine.DataLine9
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    //  *** Start programmer edit section *** (Using statements)

    //  *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Dba.
    /// </summary>
    //  *** Start programmer edit section *** (dba CustomAttributes)

    //  *** End programmer edit section *** (dba CustomAttributes)
    [PublishName("DataLine.ProtoOne.Dba")]
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("dbaE", new string[] {
            "dt_upgrade as \'Dt_upgrade\'",
            "description as \'Description\'",
            "script as \'Script\'",
            "prev_version as \'Prev_version\'",
            "prev_version.description as \'Description\'"})]
    [View("dbaL", new string[] {
            "dt_upgrade as \'Dt_upgrade\'",
            "description as \'Description\'",
            "script as \'Script\'",
            "prev_version as \'Description\'"}, Hidden=new string[] {
            "prev_version"})]
    public class dba : ICSSoft.STORMNET.DataObject
    {
        
        private System.DateTime fdt_upgrade;
        
        private string fdescription;
        
        private string fscript;
        
        private DataLine.DataLine9.dba fprev_version;
        
        //  *** Start programmer edit section *** (dba CustomMembers)

        //  *** End programmer edit section *** (dba CustomMembers)

        
        /// <summary>
        /// dt_upgrade.
        /// </summary>
        //  *** Start programmer edit section *** (dba.dt_upgrade CustomAttributes)

        //  *** End programmer edit section *** (dba.dt_upgrade CustomAttributes)
        [PublishName("DtUpgrade")]
        [NotNull()]
        public virtual System.DateTime dt_upgrade
        {
            get
            {
                //  *** Start programmer edit section *** (dba.dt_upgrade Get start)

                //  *** End programmer edit section *** (dba.dt_upgrade Get start)
                System.DateTime result = this.fdt_upgrade;
                //  *** Start programmer edit section *** (dba.dt_upgrade Get end)

                //  *** End programmer edit section *** (dba.dt_upgrade Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (dba.dt_upgrade Set start)

                //  *** End programmer edit section *** (dba.dt_upgrade Set start)
                this.fdt_upgrade = value;
                //  *** Start programmer edit section *** (dba.dt_upgrade Set end)

                //  *** End programmer edit section *** (dba.dt_upgrade Set end)
            }
        }
        
        /// <summary>
        /// description.
        /// </summary>
        //  *** Start programmer edit section *** (dba.description CustomAttributes)

        //  *** End programmer edit section *** (dba.description CustomAttributes)
        [StrLen(255)]
        [PublishName("Description")]
        public virtual string description
        {
            get
            {
                //  *** Start programmer edit section *** (dba.description Get start)

                //  *** End programmer edit section *** (dba.description Get start)
                string result = this.fdescription;
                //  *** Start programmer edit section *** (dba.description Get end)

                //  *** End programmer edit section *** (dba.description Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (dba.description Set start)

                //  *** End programmer edit section *** (dba.description Set start)
                this.fdescription = value;
                //  *** Start programmer edit section *** (dba.description Set end)

                //  *** End programmer edit section *** (dba.description Set end)
            }
        }
        
        /// <summary>
        /// script.
        /// </summary>
        //  *** Start programmer edit section *** (dba.script CustomAttributes)

        //  *** End programmer edit section *** (dba.script CustomAttributes)
        [StrLen(255)]
        [PublishName("Script")]
        [NotNull()]
        public virtual string script
        {
            get
            {
                //  *** Start programmer edit section *** (dba.script Get start)

                //  *** End programmer edit section *** (dba.script Get start)
                string result = this.fscript;
                //  *** Start programmer edit section *** (dba.script Get end)

                //  *** End programmer edit section *** (dba.script Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (dba.script Set start)

                //  *** End programmer edit section *** (dba.script Set start)
                this.fscript = value;
                //  *** Start programmer edit section *** (dba.script Set end)

                //  *** End programmer edit section *** (dba.script Set end)
            }
        }
        
        /// <summary>
        /// Dba.
        /// </summary>
        //  *** Start programmer edit section *** (dba.prev_version CustomAttributes)

        //  *** End programmer edit section *** (dba.prev_version CustomAttributes)
        [PropertyStorage(new string[] {
                "prev_version"})]
        public virtual DataLine.DataLine9.dba prev_version
        {
            get
            {
                //  *** Start programmer edit section *** (dba.prev_version Get start)

                //  *** End programmer edit section *** (dba.prev_version Get start)
                DataLine.DataLine9.dba result = this.fprev_version;
                //  *** Start programmer edit section *** (dba.prev_version Get end)

                //  *** End programmer edit section *** (dba.prev_version Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (dba.prev_version Set start)

                //  *** End programmer edit section *** (dba.prev_version Set start)
                this.fprev_version = value;
                //  *** Start programmer edit section *** (dba.prev_version Set end)

                //  *** End programmer edit section *** (dba.prev_version Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "dbaE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View dbaE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("dbaE", typeof(DataLine.DataLine9.dba));
                }
            }
            
            /// <summary>
            /// "dbaL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View dbaL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("dbaL", typeof(DataLine.DataLine9.dba));
                }
            }
        }
    }
}
