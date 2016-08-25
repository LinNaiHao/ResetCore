﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace ResetCore.ModuleControl
{
    //模块种类
    public enum MODULE_SYMBOL
    {
        ASSET,
        EVENT,
        UTIL,

        AOP,
        BEHAVIOR_TREE,
        CSTOOL,
        DATA_GENER,
        DATA_STRUCT,
        DEBUG,
        DLLMANAGER,
        FSM,
        GAMESYSTEMS,
        RESOURCES_MANAGER,
        LUA,
        MYSQL,
        NETPOST,
        NGUI,
        OBJECT,
        PLATFORM_HELPER,
        SHADER,
        TEST,
        UGUI,
        DATA_SUPPORT,

        AR,
        VR_VIVE
    }

    //SDK种类
    public enum SDKType
    {
        uLua,
        ARToolKit,
        SteamVR,
    }

    public static class ModuleConst
    {
        public static readonly List<MODULE_SYMBOL> defaultSymbol = new List<MODULE_SYMBOL>()
        {
            MODULE_SYMBOL.EVENT,
            MODULE_SYMBOL.ASSET,
            MODULE_SYMBOL.UTIL,
        };

        public static readonly string DeveloperSymbolName = "RESET_DEVELOPER";

        public static readonly Dictionary<MODULE_SYMBOL, string> SymbolName = new Dictionary<MODULE_SYMBOL, string>()
        {
            {MODULE_SYMBOL.ASSET,"ASSET"},
            {MODULE_SYMBOL.UTIL,"UTIL"},
            {MODULE_SYMBOL.EVENT,"EVENT"},

            {MODULE_SYMBOL.AOP,"AOP"},
            {MODULE_SYMBOL.BEHAVIOR_TREE,"BEHAVIOR_TREE"},
            {MODULE_SYMBOL.CSTOOL,"CSTOOL"},
            {MODULE_SYMBOL.DATA_GENER,"DATA_GENER"},
            {MODULE_SYMBOL.DATA_STRUCT,"DATA_STRUCT"},
            {MODULE_SYMBOL.DEBUG,"DEBUG"},
            {MODULE_SYMBOL.DLLMANAGER,"DLLMANAGER"},
            {MODULE_SYMBOL.FSM,"FSM"},
            {MODULE_SYMBOL.GAMESYSTEMS,"GAMESYSTEMS"},
            {MODULE_SYMBOL.RESOURCES_MANAGER,"RESOURCES_MANAGER"},
            {MODULE_SYMBOL.LUA,"LUA"},
            {MODULE_SYMBOL.MYSQL,"MYSQL"},
            {MODULE_SYMBOL.NETPOST,"NETPOST"},
            {MODULE_SYMBOL.NGUI,"NGUI"},
            {MODULE_SYMBOL.OBJECT,"OBJECT"},
            {MODULE_SYMBOL.PLATFORM_HELPER,"PLATFORMHELPER"},
            {MODULE_SYMBOL.SHADER,"SHADER"},
            {MODULE_SYMBOL.TEST,"TEST"},
            {MODULE_SYMBOL.UGUI,"UGUI"},
            {MODULE_SYMBOL.DATA_SUPPORT,"DATA_SUPPORT"},

            {MODULE_SYMBOL.AR,"AR"},
            {MODULE_SYMBOL.VR_VIVE,"VR_VIVE"},
        };

        public static readonly Dictionary<MODULE_SYMBOL, string> SymbolFoldNames = new Dictionary<MODULE_SYMBOL, string>()
        {
            {MODULE_SYMBOL.ASSET, "Core/Asset"},
            {MODULE_SYMBOL.UTIL, "Core/Util"},
            {MODULE_SYMBOL.EVENT,"Core/Events"},

            {MODULE_SYMBOL.AOP,"Aop"},
            {MODULE_SYMBOL.BEHAVIOR_TREE,"BehaviorTree"},
            {MODULE_SYMBOL.CSTOOL,"CSTool"},
            {MODULE_SYMBOL.DATA_GENER, "DataGener"},
            {MODULE_SYMBOL.DATA_STRUCT, "DataStruct"},
            {MODULE_SYMBOL.DEBUG, "Debug"},
            {MODULE_SYMBOL.DLLMANAGER, "DllManager"},
            {MODULE_SYMBOL.FSM,"FSM"},
            {MODULE_SYMBOL.GAMESYSTEMS, "GameSystems"},
            {MODULE_SYMBOL.RESOURCES_MANAGER, "ResourcesManager"},
            {MODULE_SYMBOL.LUA, "Lua"},
            {MODULE_SYMBOL.MYSQL, "MySQL"},
            {MODULE_SYMBOL.NETPOST, "NetPost"},
            {MODULE_SYMBOL.NGUI, "NGUI"},
            {MODULE_SYMBOL.OBJECT, "Object"},
            {MODULE_SYMBOL.PLATFORM_HELPER, "PlatformHelper"},
            {MODULE_SYMBOL.SHADER, "Shader"},
            {MODULE_SYMBOL.TEST, "Test"},
            {MODULE_SYMBOL.UGUI, "UGUI"},
            {MODULE_SYMBOL.DATA_SUPPORT, "DataSupport"},

            {MODULE_SYMBOL.AR, "ARToolKit"},
            {MODULE_SYMBOL.VR_VIVE, "VR_Vive"},
        };

        /// <summary>
        /// 获取模块路径
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        public static string GetSymbolPath(MODULE_SYMBOL symbol)
        {
            return Path.Combine(PathConfig.ResetCorePath, SymbolFoldNames[symbol]);
        }
        /// <summary>
        /// 获取模块备份路径
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        public static string GetSymbolTempPath(MODULE_SYMBOL symbol)
        {
            return Path.Combine(PathConfig.ResetCoreBackUpPath, SymbolFoldNames[symbol]);
        }

        //模块注释
        public static readonly Dictionary<MODULE_SYMBOL, string> SymbolComments = new Dictionary<MODULE_SYMBOL, string>()
        {
            {MODULE_SYMBOL.ASSET, "热更新基本框架以及资源管理"},
            {MODULE_SYMBOL.UTIL, "常用功能，包含大量常用扩展"},
            {MODULE_SYMBOL.EVENT,"事件分发器"},

            {MODULE_SYMBOL.AOP,"Aop扩展"},
            {MODULE_SYMBOL.BEHAVIOR_TREE,"行为树框架（开发中）"},
            {MODULE_SYMBOL.CSTOOL,"基于控制台的工具（开发中）"},
            {MODULE_SYMBOL.DATA_GENER, "游戏数据生成器"},
            {MODULE_SYMBOL.DATA_STRUCT, "数据结构（开发中）"},
            {MODULE_SYMBOL.DEBUG, "Debug扩展（开发中）"},
            {MODULE_SYMBOL.DLLMANAGER, "Dll管理器（开发中）"},
            {MODULE_SYMBOL.FSM,"有限状态机（来自github）"},
            {MODULE_SYMBOL.GAMESYSTEMS, "游戏系统"},
            {MODULE_SYMBOL.RESOURCES_MANAGER, "导入助手（来自Infinite Code）"},
            {MODULE_SYMBOL.LUA, "Lua扩展(需要安装)"},
            {MODULE_SYMBOL.MYSQL, "对MySQL进行支持（开发中）"},
            {MODULE_SYMBOL.NETPOST, "NetPost基本HTTP框架"},
            {MODULE_SYMBOL.NGUI, "NGUI基本UI框架, 已经包含NGUI插件"},
            {MODULE_SYMBOL.OBJECT, "游戏场景中对物体的控制"},
            {MODULE_SYMBOL.PLATFORM_HELPER, "对各个导出平台进行支持（开发中）"},
            {MODULE_SYMBOL.SHADER, "对Shader的扩展（开发中）"},
            {MODULE_SYMBOL.TEST, "测试模块"},
            {MODULE_SYMBOL.UGUI, "UGUI基本UI框架"},
            {MODULE_SYMBOL.DATA_SUPPORT, "对各种储存传输数据的扩展"},

            {MODULE_SYMBOL.AR, "对ARToolKit的扩展支持（需要安装）"},
            {MODULE_SYMBOL.VR_VIVE, "对SteamVR的扩展支持（需要安装）"},
        };

        public static Dictionary<SDKType, string> SDKFolderName = new Dictionary<SDKType, string>()
        {
            {SDKType.uLua, "uLua" },
            {SDKType.ARToolKit, "ARToolKit" },
            {SDKType.SteamVR, "SteamVR" },
        };

        /// <summary>
        /// 模块对应SDK
        /// </summary>
        public static Dictionary<MODULE_SYMBOL, SDKType> NeedSDKDict = new Dictionary<MODULE_SYMBOL, SDKType>()
        {
            {MODULE_SYMBOL.LUA, SDKType.uLua },
            {MODULE_SYMBOL.AR, SDKType.ARToolKit },
            {MODULE_SYMBOL.VR_VIVE, SDKType.SteamVR },
        };

        public static string GetSDKBackupPath(SDKType sdkType)
        {
            return Path.Combine(PathConfig.SDKBackupPath, SDKFolderName[sdkType]);
        }

        public static string GetSDKPathInPackage(SDKType sdkType)
        {
            return Path.Combine(PathConfig.SDKPathInPackage, SDKFolderName[sdkType]);
        }

        public static string GetSDKPath(SDKType sdkType)
        {
            return Path.Combine(PathConfig.SDKPath, SDKFolderName[sdkType]);
        }

    }

}
