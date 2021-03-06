﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace StarDust.CasparCG.net.Models
{
    /// <summary>
    /// Video format for a channel.
    /// </summary>
    [Serializable]
    public enum VideoMode
    {
        /// <summary>
        /// PAL
        /// </summary>
        [Display(Name = "PAL")]
        [AMCPCommandValue("PAL")]
        [EnumMember(Value = "PAL")]
        [XmlEnum("PAL")]
        PAL,


        /// <summary>
        /// NTSC
        /// </summary>
        [Display(Name = "NTSC")]
        [AMCPCommandValue("NTSC")]
        [EnumMember(Value = "NTSC")]
        [XmlEnum("NTSC")]
        NTSC,

        /// <summary>
        /// 576p 25fps
        /// </summary>
        [Display(Name = "576p 25p")]
        [AMCPCommandValue("576p2500")]
        [EnumMember(Value = "576p2500")]
        [XmlEnum("576p2500")]
        Mode_576p25,

        /// <summary>
        /// 720p 23.98fps
        /// </summary>
        [Display(Name = "720p 23.98Hz")]
        [AMCPCommandValue("720p2398")]
        [EnumMember(Value = "720p2398")]
        [XmlEnum("720p2398")]
        Mode_720p2398,

        /// <summary>
        /// 720p 24fps
        /// </summary>
        [Display(Name = "720p 24Hz")]
        [AMCPCommandValue("720p2400")]
        [EnumMember(Value = "720p2400")]
        [XmlEnum("720p2400")]
        Mode_720p2400,

        /// <summary>
        /// 720p 25fps
        /// </summary>
        [Display(Name = "720p 25Hz")]
        [AMCPCommandValue("720p2500")]
        [EnumMember(Value = "720p2500")]
        [XmlEnum("720p2500")]
        Mode_720p2500,

        /// <summary>
        /// 720p 29.97fps
        /// </summary>
        [Display(Name = "720p 29.97Hz")]
        [AMCPCommandValue("720p2997")]
        [EnumMember(Value = "720p2997")]
        [XmlEnum("720p2997")]
        Mode_720p2997,

        /// <summary>
        /// 720p 30fps
        /// </summary>
        [Display(Name = "720p 30Hz")]
        [AMCPCommandValue("720p3000")]
        [EnumMember(Value = "720p3000")]
        [XmlEnum("720p3000")]
        Mode_720p3000,

        /// <summary>
        /// 720p 50fps
        /// </summary>
        [Display(Name = "720p 50Hz")]
        [AMCPCommandValue("720p5000")]
        [EnumMember(Value = "720p5000")]
        [XmlEnum("720p5000")]
        Mode_720p5000,

        /// <summary>
        /// 720p 59.94fps
        /// </summary>
        [Display(Name = "720p 59.94Hz")]
        [AMCPCommandValue("720p5994")]
        [EnumMember(Value = "720p5994")]
        [XmlEnum("720p5994")]
        Mode_720p5994,

        /// <summary>
        /// 720p 60fps
        /// </summary>
        [Display(Name = "720p 60Hz")]
        [AMCPCommandValue("720p6000")]
        [EnumMember(Value = "720p6000")]
        [XmlEnum("720p6000")]
        Mode_720p6000,

        /// <summary>
        /// 1080p 23.98fps
        /// </summary>
        [Display(Name = "1080p 23.98Hz")]
        [AMCPCommandValue("1080p2398")]
        [EnumMember(Value = "1080p2398")]
        [XmlEnum("1080p2398")]
        Mode_1080p2398,

        /// <summary>
        /// 1080p 24fps
        /// </summary>
        [Display(Name = "1080p 24Hz")]
        [AMCPCommandValue("1080p2400")]
        [EnumMember(Value = "1080p2400")]
        [XmlEnum("1080p2400")]
        Mode_1080p2400,

        /// <summary>
        /// 1080p 25fps
        /// </summary>
        [Display(Name = "1080p 25Hz")]
        [AMCPCommandValue("1080p2500")]
        [EnumMember(Value = "1080p2500")]
        [XmlEnum("1080p2500")]
        Mode_1080p2500,

        /// <summary>
        /// 1080p 29.97fps
        /// </summary>
        [Display(Name = "1080p 29.97Hz")]
        [AMCPCommandValue("1080p2997")]
        [EnumMember(Value = "1080p2997")]
        [XmlEnum("1080p2997")]
        Mode_1080p2997,

        /// <summary>
        /// 1080p 30fps
        /// </summary>
        [Display(Name = "1080p 30Hz")]
        [AMCPCommandValue("1080p3000")]
        [EnumMember(Value = "1080p3000")]
        [XmlEnum("1080p3000")]
        Mode_1080p3000,

        /// <summary>
        /// 1080p 50fps
        /// </summary>
        [Display(Name = "1080p 50Hz")]
        [AMCPCommandValue("1080p5000")]
        [EnumMember(Value = "1080p5000")]
        [XmlEnum("1080p5000")]
        Mode_1080p5000,

        /// <summary>
        /// 1080i 50fps
        /// </summary>
        [Display(Name = "1080i 50Hz")]
        [AMCPCommandValue("1080i5000")]
        [EnumMember(Value = "1080i5000")]
        [XmlEnum("1080i5000")]
        Mode_1080i5000,

        /// <summary>
        /// 1080p 59.94fps
        /// </summary>
        [Display(Name = "1080p 59.940Hz")]
        [AMCPCommandValue("1080p5994")]
        [EnumMember(Value = "1080p5994")]
        [XmlEnum("1080p5994")]
        Mode_1080p5994,

        /// <summary>
        /// 1080i 59.94fps
        /// </summary>
        [Display(Name = "1080i 59.940Hz")]
        [AMCPCommandValue("1080i5994")]
        [EnumMember(Value = "1080i5994")]
        [XmlEnum("1080i5994")]
        Mode_1080i5994,

        /// <summary>
        /// 1080p 60fps
        /// </summary>
        [Display(Name = "1080p 60Hz")]
        [AMCPCommandValue("1080p6000")]
        [EnumMember(Value = "1080p6000")]
        [XmlEnum("1080p6000")]
        Mode_1080p6000,

        /// <summary>
        /// 1080i 60fps
        /// </summary>
        [Display(Name = "1080i 60Hz")]
        [AMCPCommandValue("1080i6000")]
        [EnumMember(Value = "1080i6000")]
        [XmlEnum("1080i6000")]
        Mode_1080i6000,

        /// <summary>
        /// 2160p 23.98fps
        /// </summary>
        [Display(Name = "2160p 23.98Hz")]
        [AMCPCommandValue("2160p2398")]
        [EnumMember(Value = "2160p2398")]
        [XmlEnum("2160p2398")]
        Mode_2160p2398,

        /// <summary>
        /// 2160p 24fps
        /// </summary>
        [Display(Name = "2160p 24Hz")]
        [AMCPCommandValue("2160p2400")]
        [EnumMember(Value = "2160p2400")]
        [XmlEnum("2160p2400")]
        Mode_2160p2400,

        /// <summary>
        /// 2160p 25fps
        /// </summary>
        [Display(Name = "2160p 25Hz")]
        [AMCPCommandValue("2160p2500")]
        [EnumMember(Value = "2160p2500")]
        [XmlEnum("2160p2500")]
        Mode_2160p2500,

        /// <summary>
        /// 2160p 29.97fps
        /// </summary>
        [Display(Name = "2160p 29.97Hz")]
        [AMCPCommandValue("2160p2997")]
        [EnumMember(Value = "2160p2997")]
        [XmlEnum("2160p2997")]
        Mode_2160p2997,

        /// <summary>
        /// 2160p 30fps
        /// </summary>
        [Display(Name = "2160p 30Hz")]
        [AMCPCommandValue("2160p3000")]
        [EnumMember(Value = "2160p3000")]
        [XmlEnum("2160p3000")]
        Mode_2160p3000,

        /// <summary>
        /// 2160p 50fps
        /// </summary>
        [Display(Name = "2160p 50Hz")]
        [AMCPCommandValue("2160p5000")]
        [EnumMember(Value = "2160p5000")]
        [XmlEnum("2160p5000")]
        Mode_2160p5000,

        /// <summary>
        /// 2160p 59.94fps
        /// </summary>
        [Display(Name = "2160p 59.94Hz")]
        [AMCPCommandValue("2160p5994")]
        [EnumMember(Value = "2160p5994")]
        [XmlEnum("2160p5994")]
        Mode_2160p5994,

        /// <summary>
        /// 2160p 60fps
        /// </summary>
        [Display(Name = "2160p 60Hz")]
        [AMCPCommandValue("2160p6000")]
        [EnumMember(Value = "2160p6000")]
        [XmlEnum("2160p6000")]
        Mode_2160p6000,

        /// <summary>
        /// Unknown video format
        /// </summary>
        [Display(Name = "Unknown")]
        [AMCPCommandValue("Unknown")]
        [EnumMember(Value = "Unknown")]
        Unknown,
    }
}
