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
    /// Dictionary.
    /// </summary>
    //  *** Start programmer edit section *** (dictionary CustomAttributes)

    //  *** End programmer edit section *** (dictionary CustomAttributes)
    [PublishName("DataLine.ProtoOne.Dictionary")]
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("dictionaryE", new string[] {
            "name as \'Name\'"})]
    [View("dictionaryL", new string[] {
            "name as \'Name\'"})]
    public class dictionary : ICSSoft.STORMNET.DataObject
    {
        
        private string fname;
        
        //  *** Start programmer edit section *** (dictionary CustomMembers)

        //  *** End programmer edit section *** (dictionary CustomMembers)

        
        /// <summary>
        /// name.
        /// </summary>
        //  *** Start programmer edit section *** (dictionary.name CustomAttributes)

        //  *** End programmer edit section *** (dictionary.name CustomAttributes)
        [StrLen(255)]
        [PublishName("Name")]
        [NotNull()]
        public virtual string name
        {
            get
            {
                //  *** Start programmer edit section *** (dictionary.name Get start)

                //  *** End programmer edit section *** (dictionary.name Get start)
                string result = this.fname;
                //  *** Start programmer edit section *** (dictionary.name Get end)

                //  *** End programmer edit section *** (dictionary.name Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (dictionary.name Set start)

                //  *** End programmer edit section *** (dictionary.name Set start)
                this.fname = value;
                //  *** Start programmer edit section *** (dictionary.name Set end)

                //  *** End programmer edit section *** (dictionary.name Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "dictionaryE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View dictionaryE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("dictionaryE", typeof(DataLine.DataLine9.dictionary));
                }
            }
            
            /// <summary>
            /// "dictionaryL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View dictionaryL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("dictionaryL", typeof(DataLine.DataLine9.dictionary));
                }
            }
        }
    }
}
