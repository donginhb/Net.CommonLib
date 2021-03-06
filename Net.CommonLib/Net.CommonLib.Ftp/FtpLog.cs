﻿/*******************************************************************
 * * 文件名： FtpLog.cs
 * * 文件作用： 日志记录
 * *
 * *-------------------------------------------------------------------
 * *修改历史记录：
 * *修改时间      修改人    修改内容概要
 * *2018-03-15    xwj       新增
 * *******************************************************************/

using Net.CommonLib.Log;
using System;

namespace Net.CommonLib.Ftp
{
    public class FtpLog : ILog
    {
        private string logName = "FtpLog";

        private static FtpLog instance = null;

        public static FtpLog Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FtpLog();
                }
                return instance;
            }
        }

        public void Debug(string msg)
        {
            try
            {
                new Logger(logName).Debug(msg);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void Debug(string msg, Exception e)
        {
            try
            {
                new Logger(logName).Debug(msg, e);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void Error(string msg)
        {
            try
            {
                new Logger(logName).Error(msg);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Error(string msg, Exception e)
        {
            try
            {
                new Logger(logName).Error(msg,e);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void Fatal(string msg)
        {
            try
            {
                new Logger(logName).Fatal(msg);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void Fatal(string msg, Exception e)
        {
            try
            {
                new Logger(logName).Fatal(msg,e);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Info(string msg)
        {
            try
            {
                new Logger(logName).Info(msg);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void Info(string msg, Exception e)
        {
            try
            {
                new Logger(logName).Info(msg,e);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void Warn(string msg)
        {
            try
            {
                new Logger(logName).Warn(msg);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public void Warn(string msg, Exception e)
        {
            try
            {
                new Logger(logName).Warn(msg,e);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}