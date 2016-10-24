using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace FreeBattle
{
    class func
    {
        /// <summary>
        /// 启动代理线程
        /// </summary>
        /// <returns></returns>
        [DllImport("func.dll")]
        public extern static bool Init();

        /// <summary>
        /// 安装LSP
        /// </summary>
        /// <param name="filename">释放出DLL的名称</param>
        /// <returns></returns>
        [DllImport("func.dll")]
        public extern static bool InstLsp(String filename);

        /// <summary>
        /// 卸载LSP
        /// </summary>
        /// <returns></returns>
        [DllImport("func.dll")]
        public extern static bool unInstLsp();

        /// <summary>
        /// 检测是否已安装LSP
        /// </summary>
        /// <returns></returns>
        [DllImport("func.dll")]
        public extern static bool isInstLsp();

        /// <summary>
        /// 添加代理信息
        /// </summary>
        /// <param name="Cpid">进程ID</param>
        /// <param name="user">代理账号</param>
        /// <param name="pass">代理密码</param>
        /// <param name="ip">代理IP</param>
        /// <param name="port">代理端口</param>
        /// <param name="mode">代理模式，sock5为1</param>
        /// <returns></returns>
        [DllImport("func.dll")]
        public extern static bool pAddProxy(String Cpid, String user, String pass, String ip, String port, int mode);

        /// <summary>
        /// 删除代理信息
        /// </summary>
        /// <param name="Cpid">进程ID</param>
        /// <returns></returns>
        [DllImport("func.dll")]
        public extern static bool pDelProxy(String Cpid);

        /// <summary>
        /// 接受数据量
        /// </summary>
        /// <param name="Cpid">进程ID</param>
        /// <returns></returns>
        [DllImport("func.dll")]
        public extern static Int64 pGetRecvSum(String Cpid);

        /// <summary>
        /// 发送数据量
        /// </summary>
        /// <param name="Cpid"></param>
        /// <returns></returns>
        [DllImport("func.dll")]
        public extern static Int64 pGetSendSum(String Cpid);

        /// <summary>
        /// 取出代理信息
        /// </summary>
        /// <param name="Cpid">进程ID</param>
        /// <param name="user">代理账号</param>
        /// <param name="pass">代理密码</param>
        /// <param name="ip">代理IP</param>
        /// <param name="port">代理端口</param>
        /// <param name="out_mode">代理模式，sock5为1</param>
        /// <returns></returns>
        [DllImport("func.dll")]
        public extern static bool pGetProxyInfo(String Cpid, String user, String pass, String ip, String port, out int out_mode);

        /// <summary>
        /// 修改代理信息
        /// </summary>
        /// <param name="Cpid">进程ID</param>
        /// <param name="user">代理账号</param>
        /// <param name="pass">代理密码</param>
        /// <param name="ip">代理IP</param>
        /// <param name="port">代理端口</param>
        /// <param name="in_mode">代理模式，sock5为1</param>
        /// <returns></returns>
        [DllImport("func.dll")]
        public extern static bool pUpProxyInfo(String Cpid, String user, String pass, String ip, String port, int in_mode);

        /// <summary>
        /// 检测代理账号是否有效
        /// </summary>
        /// <param name="s5ip">代理ip</param>
        /// <param name="s5port">代理端口</param>
        /// <param name="user">代理账号</param>
        /// <param name="pass">代理密码</param>
        /// <returns></returns>
        [DllImport("func.dll")]
        public extern static bool checkuser(String s5ip, int s5port, String user, int pass);

        /// <summary>
        /// 启动硬件虚拟A
        /// </summary>
        /// <param name="mode">1为启动 3为关闭</param>
        /// <returns></returns>
        [DllImport("func.dll")]
        public extern static Int64 pSsdtHookA(int mode);

        /// <summary>
        /// 启动硬件虚拟W
        /// </summary>
        /// <param name="mode">1为启动 3为关闭</param>
        /// <returns></returns>
        [DllImport("func.dll")]
        public extern static Int64 pSsdtHookW(int mode);
    }
}
