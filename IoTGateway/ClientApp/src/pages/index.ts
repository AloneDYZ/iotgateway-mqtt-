/**
 * 页面集合
 */
export default {
  actionlog: {
    name: "actionlog",
    path: "/actionlog",
    controller: "WalkingTec.Mvvm.Admin.Api,ActionLog",
    icon: "el-icon-receiving"
  },
   frameworkuserbase: {
    name: "frameworkuser",
    path: "/frameworkuser",
    controller: "WalkingTec.Mvvm.Admin.Api,FrameworkUser",
    icon: "el-icon-user"
  },
  frameworkrole: {
    name: "frameworkrole",
    path: "/frameworkrole",
    controller: "WalkingTec.Mvvm.Admin.Api,FrameworkRole",
    icon: "el-icon-s-custom"
  },
 frameworkgroup: {
    name: "frameworkgroup",
    path: "/frameworkgroup",
    controller: "WalkingTec.Mvvm.Admin.Api,FrameworkGroup",
    icon: "el-icon-office-building"
  },
  frameworkmenu: {
    name: "frameworkmenu",
    path: "/frameworkmenu",
    controller: "WalkingTec.Mvvm.Admin.Api,FrameworkMenu",
    icon: "el-icon-menu"
  },
  dataprivilege: {
    name: "dataprivilege",
    path: "/dataprivilege",
    controller: "WalkingTec.Mvvm.Admin.Api,DataPrivilege",
    icon: "el-icon-odometer"
  }

, device: {
    name: '设备维护',
    path: '/device',
    controller: 'IoTGateway.Controllers,Device'
    }

, driver: {
    name: '驱动管理',
    path: '/driver',
    controller: 'IoTGateway.Controllers,Driver'
    }

, deviceconfig: {
    name: '通讯配置',
    path: '/deviceconfig',
    controller: 'IoTGateway.Controllers,DeviceConfig'
    }

, devicevariable: {
    name: '变量配置',
    path: '/devicevariable',
    controller: 'IoTGateway.Controllers,DeviceVariable'
    }

, systemconfig: {
    name: '传输配置',
    path: '/systemconfig',
    controller: 'IoTGateway.Controllers,SystemConfig'
    }
/**WTM**/
 
 
 
 
 
};
