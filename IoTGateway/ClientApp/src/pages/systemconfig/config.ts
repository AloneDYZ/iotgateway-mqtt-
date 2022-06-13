import i18n from "@/lang";

export const ASSEMBLIES: Array<string> = [
  "add",
  "edit",
  "delete",
  "export",
  "imported"
];

export const TABLE_HEADER: Array<object> = [


    {
        key: "GatewayName",
        label: "网关名称"
    },
    {
        key: "MqttIp",
        label: "Mqtt服务器"
    },
    {
        key: "MqttPort",
        label: "Mqtt端口"
    },
    {
        key: "MqttUName",
        label: "Mqtt用户名"
    },
    {
        key: "MqttUPwd",
        label: "Mqtt密码"
    },
    {
        key: "IoTPlatformType",
        label: "输出平台"
    },
  { isOperate: true, label: i18n.t(`table.actions`), actions: ["detail", "edit", "deleted"] } //操作列
];

export const IoTPlatformTypeTypes: Array<any> = [
  { Text: "ThingsBoard", Value: "ThingsBoard" },
  { Text: "IoTSharp", Value: "IoTSharp" },
  { Text: "阿里物联网平台", Value: "AliCloudIoT" },
  { Text: "腾讯智能云", Value: "TencentIoTHub" },
  { Text: "百度物联网通信", Value: "BaiduIoTCore" },
  { Text: "中移OneNet", Value: "OneNET" },
  { Text: "ThingsCloud", Value: "ThingsCloud" },
  { Text: "IotDB", Value: "IotDB" }
];

