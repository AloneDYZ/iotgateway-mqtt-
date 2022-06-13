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
        key: "Name",
        label: "变量名"
    },
    {
        key: "Description",
        label: "描述"
    },
    {
        key: "Method",
        label: "方法"
    },
    {
        key: "DeviceAddress",
        label: "地址"
    },
    {
        key: "DataType",
        label: "类型"
    },
    {
        key: "Expressions",
        label: "表达式"
    },
    {
        key: "ProtectType",
        label: "权限"
    },
    {
        key: "DeviceName_view",
        label: "Device"
    },
  { isOperate: true, label: i18n.t(`table.actions`), actions: ["detail", "edit", "deleted"] } //操作列
];

export const DataTypeTypes: Array<any> = [
  { Text: "bit", Value: "Bit" },
  { Text: "bool", Value: "Bool" },
  { Text: "uint8", Value: "UByte" },
  { Text: "int8", Value: "Byte" },
  { Text: "uint16", Value: "Uint16" },
  { Text: "int16", Value: "Int16" },
  { Text: "bcd16", Value: "Bcd16" },
  { Text: "uint32", Value: "Uint32" },
  { Text: "int32", Value: "Int32" },
  { Text: "float", Value: "Float" },
  { Text: "bcd32", Value: "Bcd32" },
  { Text: "uint64", Value: "Uint64" },
  { Text: "int64", Value: "Int64" },
  { Text: "double", Value: "Double" },
  { Text: "ascii", Value: "AsciiString" },
  { Text: "utf8", Value: "Utf8String" },
  { Text: "datetime", Value: "DateTime" },
  { Text: "timestamp(ms)", Value: "TimeStampMs" },
  { Text: "timestamp(s)", Value: "TimeStampS" },
  { Text: "任意类型", Value: "Any" },
  { Text: "自定义1", Value: "Custome1" },
  { Text: "自定义2", Value: "Custome2" },
  { Text: "自定义3", Value: "Custome3" },
  { Text: "自定义4", Value: "Custome4" },
  { Text: "自定义5", Value: "Custome5" }
];
export const ProtectTypeTypes: Array<any> = [
  { Text: "只读", Value: "ReadOnly" },
  { Text: "读写", Value: "ReadWrite" }
];

