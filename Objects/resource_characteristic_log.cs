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
    /// Resource_characteristic_log.
    /// </summary>
    //  *** Start programmer edit section *** (resource_characteristic_log CustomAttributes)

    //  *** End programmer edit section *** (resource_characteristic_log CustomAttributes)
    [PublishName("DataLine.ProtoOne.ResourceCharacteristicLog")]
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("resource_characteristic_logE", new string[] {
            "resource_characteristic_id as \'Resource_characteristic_id\'",
            "name as \'Name\'",
            "value as \'Value\'",
            "resource_id as \'Resource_id\'",
            "start_time as \'Start_time\'",
            "end_time as \'End_time\'"})]
    [View("resource_characteristic_logL", new string[] {
            "resource_characteristic_id as \'Resource_characteristic_id\'",
            "name as \'Name\'",
            "value as \'Value\'",
            "resource_id as \'Resource_id\'",
            "start_time as \'Start_time\'",
            "end_time as \'End_time\'"})]
    public class resource_characteristic_log : ICSSoft.STORMNET.DataObject
    {
        
        private int fresource_characteristic_id;
        
        private string fname;
        
        private string fvalue;
        
        private int fresource_id;
        
        private System.DateTime fstart_time;
        
        private System.DateTime fend_time;
        
        //  *** Start programmer edit section *** (resource_characteristic_log CustomMembers)

        //  *** End programmer edit section *** (resource_characteristic_log CustomMembers)

        
        /// <summary>
        /// resource_characteristic_id.
        /// </summary>
        //  *** Start programmer edit section *** (resource_characteristic_log.resource_characteristic_id CustomAttributes)

        //  *** End programmer edit section *** (resource_characteristic_log.resource_characteristic_id CustomAttributes)
        [PublishName("ResourceCharacteristicId")]
        [NotNull()]
        public virtual int resource_characteristic_id
        {
            get
            {
                //  *** Start programmer edit section *** (resource_characteristic_log.resource_characteristic_id Get start)

                //  *** End programmer edit section *** (resource_characteristic_log.resource_characteristic_id Get start)
                int result = this.fresource_characteristic_id;
                //  *** Start programmer edit section *** (resource_characteristic_log.resource_characteristic_id Get end)

                //  *** End programmer edit section *** (resource_characteristic_log.resource_characteristic_id Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (resource_characteristic_log.resource_characteristic_id Set start)

                //  *** End programmer edit section *** (resource_characteristic_log.resource_characteristic_id Set start)
                this.fresource_characteristic_id = value;
                //  *** Start programmer edit section *** (resource_characteristic_log.resource_characteristic_id Set end)

                //  *** End programmer edit section *** (resource_characteristic_log.resource_characteristic_id Set end)
            }
        }
        
        /// <summary>
        /// name.
        /// </summary>
        //  *** Start programmer edit section *** (resource_characteristic_log.name CustomAttributes)

        //  *** End programmer edit section *** (resource_characteristic_log.name CustomAttributes)
        [StrLen(255)]
        [PublishName("Name")]
        public virtual string name
        {
            get
            {
                //  *** Start programmer edit section *** (resource_characteristic_log.name Get start)

                //  *** End programmer edit section *** (resource_characteristic_log.name Get start)
                string result = this.fname;
                //  *** Start programmer edit section *** (resource_characteristic_log.name Get end)

                //  *** End programmer edit section *** (resource_characteristic_log.name Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (resource_characteristic_log.name Set start)

                //  *** End programmer edit section *** (resource_characteristic_log.name Set start)
                this.fname = value;
                //  *** Start programmer edit section *** (resource_characteristic_log.name Set end)

                //  *** End programmer edit section *** (resource_characteristic_log.name Set end)
            }
        }
        
        /// <summary>
        /// value.
        /// </summary>
        //  *** Start programmer edit section *** (resource_characteristic_log.value CustomAttributes)

        //  *** End programmer edit section *** (resource_characteristic_log.value CustomAttributes)
        [StrLen(255)]
        [PublishName("Value")]
        public virtual string value
        {
            get
            {
                //  *** Start programmer edit section *** (resource_characteristic_log.value Get start)

                //  *** End programmer edit section *** (resource_characteristic_log.value Get start)
                string result = this.fvalue;
                //  *** Start programmer edit section *** (resource_characteristic_log.value Get end)

                //  *** End programmer edit section *** (resource_characteristic_log.value Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (resource_characteristic_log.value Set start)

                //  *** End programmer edit section *** (resource_characteristic_log.value Set start)
                this.fvalue = value;
                //  *** Start programmer edit section *** (resource_characteristic_log.value Set end)

                //  *** End programmer edit section *** (resource_characteristic_log.value Set end)
            }
        }
        
        /// <summary>
        /// resource_id.
        /// </summary>
        //  *** Start programmer edit section *** (resource_characteristic_log.resource_id CustomAttributes)

        //  *** End programmer edit section *** (resource_characteristic_log.resource_id CustomAttributes)
        [PublishName("ResourceId")]
        public virtual int resource_id
        {
            get
            {
                //  *** Start programmer edit section *** (resource_characteristic_log.resource_id Get start)

                //  *** End programmer edit section *** (resource_characteristic_log.resource_id Get start)
                int result = this.fresource_id;
                //  *** Start programmer edit section *** (resource_characteristic_log.resource_id Get end)

                //  *** End programmer edit section *** (resource_characteristic_log.resource_id Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (resource_characteristic_log.resource_id Set start)

                //  *** End programmer edit section *** (resource_characteristic_log.resource_id Set start)
                this.fresource_id = value;
                //  *** Start programmer edit section *** (resource_characteristic_log.resource_id Set end)

                //  *** End programmer edit section *** (resource_characteristic_log.resource_id Set end)
            }
        }
        
        /// <summary>
        /// start_time.
        /// </summary>
        //  *** Start programmer edit section *** (resource_characteristic_log.start_time CustomAttributes)

        //  *** End programmer edit section *** (resource_characteristic_log.start_time CustomAttributes)
        [PublishName("StartTime")]
        [NotNull()]
        public virtual System.DateTime start_time
        {
            get
            {
                //  *** Start programmer edit section *** (resource_characteristic_log.start_time Get start)

                //  *** End programmer edit section *** (resource_characteristic_log.start_time Get start)
                System.DateTime result = this.fstart_time;
                //  *** Start programmer edit section *** (resource_characteristic_log.start_time Get end)

                //  *** End programmer edit section *** (resource_characteristic_log.start_time Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (resource_characteristic_log.start_time Set start)

                //  *** End programmer edit section *** (resource_characteristic_log.start_time Set start)
                this.fstart_time = value;
                //  *** Start programmer edit section *** (resource_characteristic_log.start_time Set end)

                //  *** End programmer edit section *** (resource_characteristic_log.start_time Set end)
            }
        }
        
        /// <summary>
        /// end_time.
        /// </summary>
        //  *** Start programmer edit section *** (resource_characteristic_log.end_time CustomAttributes)

        //  *** End programmer edit section *** (resource_characteristic_log.end_time CustomAttributes)
        [PublishName("EndTime")]
        [NotNull()]
        public virtual System.DateTime end_time
        {
            get
            {
                //  *** Start programmer edit section *** (resource_characteristic_log.end_time Get start)

                //  *** End programmer edit section *** (resource_characteristic_log.end_time Get start)
                System.DateTime result = this.fend_time;
                //  *** Start programmer edit section *** (resource_characteristic_log.end_time Get end)

                //  *** End programmer edit section *** (resource_characteristic_log.end_time Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (resource_characteristic_log.end_time Set start)

                //  *** End programmer edit section *** (resource_characteristic_log.end_time Set start)
                this.fend_time = value;
                //  *** Start programmer edit section *** (resource_characteristic_log.end_time Set end)

                //  *** End programmer edit section *** (resource_characteristic_log.end_time Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "resource_characteristic_logE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View resource_characteristic_logE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("resource_characteristic_logE", typeof(DataLine.DataLine9.resource_characteristic_log));
                }
            }
            
            /// <summary>
            /// "resource_characteristic_logL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View resource_characteristic_logL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("resource_characteristic_logL", typeof(DataLine.DataLine9.resource_characteristic_log));
                }
            }
        }
    }
}
