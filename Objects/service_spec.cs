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
    /// Service_spec.
    /// </summary>
    //  *** Start programmer edit section *** (service_spec CustomAttributes)

    //  *** End programmer edit section *** (service_spec CustomAttributes)
    [PublishName("DataLine.ProtoOne.ServiceSpec")]
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("service_specE", new string[] {
            "version as \'Version\'",
            "enum as \'Enum\'",
            "category as \'Category\'",
            "name as \'Name\'",
            "description as \'Description\'",
            "dt_created as \'Dt_created\'",
            "dt_modified as \'Dt_modified\'",
            "cardinality as \'Cardinality\'",
            "cardinality.description as \'Description\'",
            "cardinality as \'Cardinality\'",
            "cardinality.description as \'Description\'",
            "parent_id as \'Parent_id\'",
            "parent_id.enum as \'Enum\'",
            "catalog_key as \'Catalog_key\'",
            "catalog_key.code as \'Code\'",
            "parent_id as \'Parent_id\'",
            "parent_id.enum as \'Enum\'"})]
    [View("service_specL", new string[] {
            "version as \'Version\'",
            "enum as \'Enum\'",
            "category as \'Category\'",
            "name as \'Name\'",
            "description as \'Description\'",
            "dt_created as \'Dt_created\'",
            "dt_modified as \'Dt_modified\'",
            "cardinality as \'Description\'",
            "cardinality as \'Description\'",
            "parent_id as \'Enum\'",
            "catalog_key as \'Code\'",
            "parent_id as \'Enum\'"}, Hidden=new string[] {
            "cardinality",
            "cardinality",
            "parent_id",
            "catalog_key",
            "parent_id"})]
    public class service_spec : ICSSoft.STORMNET.DataObject
    {
        
        private int fversion;
        
        private string fenum;
        
        private string fcategory;
        
        private string fname;
        
        private string fdescription;
        
        private System.DateTime fdt_created;
        
        private System.DateTime fdt_modified;
        
        private DataLine.DataLine9.catalog fcatalog_key;
        
        private DataLine.DataLine9.cardinality_type fcardinality;
        
        private DataLine.DataLine9.service_spec fparent_id;
        
        //  *** Start programmer edit section *** (service_spec CustomMembers)

        //  *** End programmer edit section *** (service_spec CustomMembers)

        
        /// <summary>
        /// version.
        /// </summary>
        //  *** Start programmer edit section *** (service_spec.version CustomAttributes)

        //  *** End programmer edit section *** (service_spec.version CustomAttributes)
        [PublishName("Version")]
        [NotNull()]
        public virtual int version
        {
            get
            {
                //  *** Start programmer edit section *** (service_spec.version Get start)

                //  *** End programmer edit section *** (service_spec.version Get start)
                int result = this.fversion;
                //  *** Start programmer edit section *** (service_spec.version Get end)

                //  *** End programmer edit section *** (service_spec.version Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (service_spec.version Set start)

                //  *** End programmer edit section *** (service_spec.version Set start)
                this.fversion = value;
                //  *** Start programmer edit section *** (service_spec.version Set end)

                //  *** End programmer edit section *** (service_spec.version Set end)
            }
        }
        
        /// <summary>
        /// enum.
        /// </summary>
        //  *** Start programmer edit section *** (service_spec.enum CustomAttributes)

        //  *** End programmer edit section *** (service_spec.enum CustomAttributes)
        [StrLen(32)]
        [PublishName("Enum")]
        [NotNull()]
        public virtual string @enum
        {
            get
            {
                //  *** Start programmer edit section *** (service_spec.enum Get start)

                //  *** End programmer edit section *** (service_spec.enum Get start)
                string result = this.fenum;
                //  *** Start programmer edit section *** (service_spec.enum Get end)

                //  *** End programmer edit section *** (service_spec.enum Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (service_spec.enum Set start)

                //  *** End programmer edit section *** (service_spec.enum Set start)
                this.fenum = value;
                //  *** Start programmer edit section *** (service_spec.enum Set end)

                //  *** End programmer edit section *** (service_spec.enum Set end)
            }
        }
        
        /// <summary>
        /// category.
        /// </summary>
        //  *** Start programmer edit section *** (service_spec.category CustomAttributes)

        //  *** End programmer edit section *** (service_spec.category CustomAttributes)
        [StrLen(3)]
        [PublishName("Category")]
        [NotNull()]
        public virtual string category
        {
            get
            {
                //  *** Start programmer edit section *** (service_spec.category Get start)

                //  *** End programmer edit section *** (service_spec.category Get start)
                string result = this.fcategory;
                //  *** Start programmer edit section *** (service_spec.category Get end)

                //  *** End programmer edit section *** (service_spec.category Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (service_spec.category Set start)

                //  *** End programmer edit section *** (service_spec.category Set start)
                this.fcategory = value;
                //  *** Start programmer edit section *** (service_spec.category Set end)

                //  *** End programmer edit section *** (service_spec.category Set end)
            }
        }
        
        /// <summary>
        /// name.
        /// </summary>
        //  *** Start programmer edit section *** (service_spec.name CustomAttributes)

        //  *** End programmer edit section *** (service_spec.name CustomAttributes)
        [StrLen(255)]
        [PublishName("Name")]
        [NotNull()]
        public virtual string name
        {
            get
            {
                //  *** Start programmer edit section *** (service_spec.name Get start)

                //  *** End programmer edit section *** (service_spec.name Get start)
                string result = this.fname;
                //  *** Start programmer edit section *** (service_spec.name Get end)

                //  *** End programmer edit section *** (service_spec.name Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (service_spec.name Set start)

                //  *** End programmer edit section *** (service_spec.name Set start)
                this.fname = value;
                //  *** Start programmer edit section *** (service_spec.name Set end)

                //  *** End programmer edit section *** (service_spec.name Set end)
            }
        }
        
        /// <summary>
        /// description.
        /// </summary>
        //  *** Start programmer edit section *** (service_spec.description CustomAttributes)

        //  *** End programmer edit section *** (service_spec.description CustomAttributes)
        [PublishName("Description")]
        public virtual string description
        {
            get
            {
                //  *** Start programmer edit section *** (service_spec.description Get start)

                //  *** End programmer edit section *** (service_spec.description Get start)
                string result = this.fdescription;
                //  *** Start programmer edit section *** (service_spec.description Get end)

                //  *** End programmer edit section *** (service_spec.description Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (service_spec.description Set start)

                //  *** End programmer edit section *** (service_spec.description Set start)
                this.fdescription = value;
                //  *** Start programmer edit section *** (service_spec.description Set end)

                //  *** End programmer edit section *** (service_spec.description Set end)
            }
        }
        
        /// <summary>
        /// dt_created.
        /// </summary>
        //  *** Start programmer edit section *** (service_spec.dt_created CustomAttributes)

        //  *** End programmer edit section *** (service_spec.dt_created CustomAttributes)
        [PublishName("DtCreated")]
        [NotNull()]
        public virtual System.DateTime dt_created
        {
            get
            {
                //  *** Start programmer edit section *** (service_spec.dt_created Get start)

                //  *** End programmer edit section *** (service_spec.dt_created Get start)
                System.DateTime result = this.fdt_created;
                //  *** Start programmer edit section *** (service_spec.dt_created Get end)

                //  *** End programmer edit section *** (service_spec.dt_created Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (service_spec.dt_created Set start)

                //  *** End programmer edit section *** (service_spec.dt_created Set start)
                this.fdt_created = value;
                //  *** Start programmer edit section *** (service_spec.dt_created Set end)

                //  *** End programmer edit section *** (service_spec.dt_created Set end)
            }
        }
        
        /// <summary>
        /// dt_modified.
        /// </summary>
        //  *** Start programmer edit section *** (service_spec.dt_modified CustomAttributes)

        //  *** End programmer edit section *** (service_spec.dt_modified CustomAttributes)
        [PublishName("DtModified")]
        [NotNull()]
        public virtual System.DateTime dt_modified
        {
            get
            {
                //  *** Start programmer edit section *** (service_spec.dt_modified Get start)

                //  *** End programmer edit section *** (service_spec.dt_modified Get start)
                System.DateTime result = this.fdt_modified;
                //  *** Start programmer edit section *** (service_spec.dt_modified Get end)

                //  *** End programmer edit section *** (service_spec.dt_modified Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (service_spec.dt_modified Set start)

                //  *** End programmer edit section *** (service_spec.dt_modified Set start)
                this.fdt_modified = value;
                //  *** Start programmer edit section *** (service_spec.dt_modified Set end)

                //  *** End programmer edit section *** (service_spec.dt_modified Set end)
            }
        }
        
        /// <summary>
        /// Service_spec.
        /// </summary>
        //  *** Start programmer edit section *** (service_spec.catalog_key CustomAttributes)

        //  *** End programmer edit section *** (service_spec.catalog_key CustomAttributes)
        [PropertyStorage(new string[] {
                "catalog_key"})]
        [PublishName("CatalogKey")]
        public virtual DataLine.DataLine9.catalog catalog_key
        {
            get
            {
                //  *** Start programmer edit section *** (service_spec.catalog_key Get start)

                //  *** End programmer edit section *** (service_spec.catalog_key Get start)
                DataLine.DataLine9.catalog result = this.fcatalog_key;
                //  *** Start programmer edit section *** (service_spec.catalog_key Get end)

                //  *** End programmer edit section *** (service_spec.catalog_key Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (service_spec.catalog_key Set start)

                //  *** End programmer edit section *** (service_spec.catalog_key Set start)
                this.fcatalog_key = value;
                //  *** Start programmer edit section *** (service_spec.catalog_key Set end)

                //  *** End programmer edit section *** (service_spec.catalog_key Set end)
            }
        }
        
        /// <summary>
        /// Service_spec.
        /// </summary>
        //  *** Start programmer edit section *** (service_spec.cardinality CustomAttributes)

        //  *** End programmer edit section *** (service_spec.cardinality CustomAttributes)
        [PropertyStorage(new string[] {
                "cardinality"})]
        [PublishName("Cardinality")]
        [NotNull()]
        public virtual DataLine.DataLine9.cardinality_type cardinality
        {
            get
            {
                //  *** Start programmer edit section *** (service_spec.cardinality Get start)

                //  *** End programmer edit section *** (service_spec.cardinality Get start)
                DataLine.DataLine9.cardinality_type result = this.fcardinality;
                //  *** Start programmer edit section *** (service_spec.cardinality Get end)

                //  *** End programmer edit section *** (service_spec.cardinality Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (service_spec.cardinality Set start)

                //  *** End programmer edit section *** (service_spec.cardinality Set start)
                this.fcardinality = value;
                //  *** Start programmer edit section *** (service_spec.cardinality Set end)

                //  *** End programmer edit section *** (service_spec.cardinality Set end)
            }
        }
        
        /// <summary>
        /// Service_spec.
        /// </summary>
        //  *** Start programmer edit section *** (service_spec.parent_id CustomAttributes)

        //  *** End programmer edit section *** (service_spec.parent_id CustomAttributes)
        [NotNull()]
        public virtual DataLine.DataLine9.service_spec parent_id
        {
            get
            {
                //  *** Start programmer edit section *** (service_spec.parent_id Get start)

                //  *** End programmer edit section *** (service_spec.parent_id Get start)
                DataLine.DataLine9.service_spec result = this.fparent_id;
                //  *** Start programmer edit section *** (service_spec.parent_id Get end)

                //  *** End programmer edit section *** (service_spec.parent_id Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (service_spec.parent_id Set start)

                //  *** End programmer edit section *** (service_spec.parent_id Set start)
                this.fparent_id = value;
                //  *** Start programmer edit section *** (service_spec.parent_id Set end)

                //  *** End programmer edit section *** (service_spec.parent_id Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "service_specE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View service_specE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("service_specE", typeof(DataLine.DataLine9.service_spec));
                }
            }
            
            /// <summary>
            /// "service_specL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View service_specL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("service_specL", typeof(DataLine.DataLine9.service_spec));
                }
            }
        }
    }
}
