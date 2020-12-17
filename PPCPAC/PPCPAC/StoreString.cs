using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;

namespace PPCPAC
{
    class RegStoreClass : IDisposable
    {
        RegistryKey m_regKey = null;
        String m_AppName = "";
        String m_Value = "";
        public String sValue
        {
            get
            {
                readReg();
                return m_Value;
            }
            set
            {
                m_Value = value;
                this.writeReg();
            }
        }
        String AppName
        {
            get
            {
                if (m_AppName == "")
                {
                    //get the executable name
                    m_AppName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
                    //remove extra infos

                }
                return m_AppName;
            }
        }
        public RegStoreClass()
        {

            try
            {
                //open or create sub key for read/write
                m_regKey = Registry.LocalMachine.CreateSubKey(AppName);
            }
            catch (Exception)
            {
            }
            //try to read value from sub key
            if (!readReg())
            {
                //something failed, write actual value to reg
                writeReg();
            }
        }
        public void Dispose()
        {
            m_regKey.Flush();
            m_regKey.Close();
        }
        bool readReg()
        {
            bool bRet = false;
            try
            {
                string s = (string)m_regKey.GetValue("Value", "n/a");
                m_Value = s;
                bRet = true;
            }
            catch (Exception)
            {
            }
            return bRet;
        }
        bool writeReg()
        {
            bool bRet = false;
            try
            {
                m_regKey.SetValue("Value", m_Value, RegistryValueKind.String);
                m_regKey.Flush();
                bRet = true;
            }
            catch (Exception)
            {

            }
            return bRet;
        }
    }
}
