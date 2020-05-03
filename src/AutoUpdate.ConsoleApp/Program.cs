﻿using GeneralUpdate.Core;
using GeneralUpdate.Core.Strategys;
using GeneralUpdate.Core.Update;
using System;

namespace AutoApdate.ConsoleApp
{
    class Program
    {
        /// <summary>
        /// quick start
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region Launch1

            args = new string[6] {
                "0.0.0.0",
                "1.1.1.1",
                "https://github.com/WELL-E",
                 "http://192.168.50.225:7000/update.zip",
                 @"E:\PlatformPath",
                "509f0ede227de4a662763a4abe3d8470",
                 };

            GeneralUpdateBootstrap bootstrap = new GeneralUpdateBootstrap();
            bootstrap.DownloadStatistics += OnDownloadStatistics;
            bootstrap.ProgressChanged += OnProgressChanged;
            bootstrap.Strategy<DefultStrategy>().
                Option(UpdateOption.Format, "zip").
                Option(UpdateOption.MainApp, "KGS.CPP").
                RemoteAddress(args).
                Launch();

            #endregion

            #region Launch2

            //GeneralUpdateBootstrap bootstrap2 = new GeneralUpdateBootstrap();
            //bootstrap2.DownloadStatistics += OnDownloadStatistics;
            //bootstrap2.ProgressChanged += OnProgressChanged;
            //bootstrap2.Strategy<DefultStrategy>().
            //    Option(UpdateOption.Format, "zip").
            //    Option(UpdateOption.MainApp, "KGS.CPP").
            //    RemoteAddress(@"https://api.com/GeneralUpdate?version=1.0.0.1").
            //    Launch();

            #endregion

            Console.Read();
        }

        private static void OnProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.Type == ProgressType.Updatefile)
            {
                var str = $"当前更新第：{e.ProgressValue}个,更新文件总数：{e.TotalSize}";
                Console.WriteLine(str);
            }

            if (e.Type == ProgressType.Done)
            {
                Console.WriteLine("更新完成");
            }
        }

        private static void OnDownloadStatistics(object sender, DownloadStatisticsEventArgs e)
        {
            Console.WriteLine($"下载速度：{e.Speed}，剩余时间：{e.Remaining.Minute}:{e.Remaining.Second}");
        }
    }
}