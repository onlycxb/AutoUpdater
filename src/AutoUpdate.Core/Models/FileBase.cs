﻿using GeneralUpdate.Core.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralUpdate.Core.Models
{
    public enum FileStatus
    {
        Remove = 0,
        New = 1,
        Update = 2,
        None = -1
    }

    public class FileBase : IFile
    {
        public FileStatus Status { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// MD5校验码
        /// </summary>
        public string MD5 { get; set; }

        /// <summary>
        /// 当前版本
        /// </summary>
        public string CurrentVersion { get; set; }

        /// <summary>
        /// 最新版本
        /// </summary>
        public string NewVersion { get; set; }

        /// <summary>
        /// 文件唯一id
        /// </summary>
        public string Guid { get; set; }

        /// <summary>
        /// 文件大小
        /// </summary>
        public long Size { get; set; }

        /// <summary>
        /// 下载的文件大小
        /// </summary>
        public long? TotalSize { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// 安装路径
        /// </summary>
        public string InstallPath { get; set; }

        /// <summary>
        /// 下载文件临时存储路径
        /// </summary>
        public string TempPath { get; set; }
    }
}