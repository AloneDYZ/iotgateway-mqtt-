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
        key: "DeviceConfigName",
        label: "名称"
    },
    {
        key: "DataSide",
        label: "属性侧"
    },
    {
        key: "Description",
        label: "描述"
    },
    {
        key: "Value",
        label: "值"
    },
    {
        key: "EnumInfo",
        label: "备注"
    },
    {
        key: "DeviceName_view",
        label: "Device"
    },
  { isOperate: true, label: i18n.t(`table.actions`), actions: ["detail", "edit", "deleted"] } //操作列
];

export const DataSideTypes: Array<any> = [
  { Text: "共享属性", Value: "AnySide" },
  { Text: "客户端属性", Value: "ClientSide" }
];

