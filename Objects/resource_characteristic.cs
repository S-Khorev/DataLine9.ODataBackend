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
    /// Resource_characteristic.
    /// </summary>
    //  *** Start programmer edit section *** (resource_characteristic CustomAttributes)

    //  *** End programmer edit section *** (resource_characteristic CustomAttributes)
    [PublishName("DataLine.ProtoOne.ResourceCharacteristic")]
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("resource_characteristicE", new string[] {
            "name as \'Name\'",
            "value as \'Value\'",
            "resource_id as \'Resource_id\'",
            "resource_id.name as \'Name\'"})]
    [View("resource_characteristicL", new string[] {
            "name as \'Name\'",
            "value as \'Value\'",
            "resource_id.name as \'Name\'"})]
    public class resource_characteristic : ICSSoft.STORMNET.DataObject
    {
        
        private string fname;
        
        private string fvalue;
        
        private DataLine.DataLine9.resource fresource_id;
        
        //  *** Start programmer edit section *** (resource_characteristic CustomMembers)

        //  *** End programmer edit section *** (resource_characteristic CustomMembers)

        
        /// <summary>
        /// name.
        /// </summary>
        //  *** Start programmer edit section *** (resource_characteristic.name CustomAttributes)

        //  *** End programmer edit section *** (resource_characteristic.name CustomAttributes)
        [StrLen(255)]
        [PublishName("Name")]
        [NotNull()]
        public virtual string name
        {
            get
            {
                //  *** Start programmer edit section *** (resource_characteristic.name Get start)

                //  *** End programmer edit section *** (resource_characteristic.name Get start)
                string result = this.fname;
                //  *** Start programmer edit section *** (resource_characteristic.name Get end)

                //  *** End programmer edit section *** (resource_characteristic.name Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (resource_characteristic.name Set start)

                //  *** End programmer edit section *** (resource_characteristic.name Set start)
                this.fname = value;
                //  *** Start programmer edit section *** (resource_characteristic.name Set end)

                //  *** End programmer edit section *** (resource_characteristic.name Set end)
            }
        }
        
        /// <summary>
        /// value.
        /// </summary>
        //  *** Start programmer edit section *** (resource_characteristic.value CustomAttributes)

        //  *** End programmer edit section *** (resource_characteristic.value CustomAttributes)
        [StrLen(255)]
        [PublishName("Value")]
        public virtual string value
        {
            get
            {
                //  *** Start programmer edit section *** (resource_characteristic.value Get start)

                //  *** End programmer edit section *** (resource_characteristic.value Get start)
                string result = this.fvalue;
                //  *** Start programmer edit section *** (resource_characteristic.value Get end)

                //  *** End programmer edit section *** (resource_characteristic.value Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (resource_characteristic.value Set start)

                //  *** End programmer edit section *** (resource_characteristic.value Set start)
                this.fvalue = value;
                //  *** Start programmer edit section *** (resource_characteristic.value Set end)

                //  *** End programmer edit section *** (resource_characteristic.value Set end)
            }
        }
        
        /// <summary>
        /// Resource_characteristic.
        /// </summary>
        //  *** Start programmer edit section *** (resource_characteristic.resource_id CustomAttributes)

        //  *** End programmer edit section *** (resource_characteristic.resource_id CustomAttributes)
        [PropertyStorage(new string[] {
                "resource_id"})]
        [NotNull()]
        public virtual DataLine.DataLine9.resource resource_id
        {
            get
            {
                //  *** Start programmer edit section *** (resource_characteristic.resource_id Get start)

                //  *** End programmer edit section *** (resource_characteristic.resource_id Get start)
                DataLine.DataLine9.resource result = this.fresource_id;
                //  *** Start programmer edit section *** (resource_characteristic.resource_id Get end)

                //  *** End programmer edit section *** (resource_characteristic.resource_id Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (resource_characteristic.resource_id Set start)

                //  *** End programmer edit section *** (resource_characteristic.resource_id Set start)
                this.fresource_id = value;
                //  *** Start programmer edit section *** (resource_characteristic.resource_id Set end)

                //  *** End programmer edit section *** (resource_characteristic.resource_id Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "resource_characteristicE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View resource_characteristicE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("resource_characteristicE", typeof(DataLine.DataLine9.resource_characteristic));
                }
            }
            
            /// <summary>
            /// "resource_characteristicL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View resource_characteristicL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("resource_characteristicL", typeof(DataLine.DataLine9.resource_characteristic));
                }
            }
        }
    }
}
