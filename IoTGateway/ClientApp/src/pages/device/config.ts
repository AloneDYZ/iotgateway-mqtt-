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
        key: "DeviceName",
        label: "名称"
    },
    {
        key: "Index",
        label: "排序"
    },
    /* {
        key: "Description",
        label: "描述"
    }, */
    {
        key: "AssembleName_view",
        label: "驱动"
    },
    {
        key: "AutoStart",
        label: "启动",
        isSlot: true 
    },
    {
        key: "CgUpload",
        label: "变化上传",
        isSlot: true 
    },
    {
        key: "EnforcePeriod",
        label: "归档周期ms"
    },
   /*  {
        key: "DeviceTypeEnum",
        label: "类型"
    }, */
    /* {
        key: "DeviceName_view",
        label: "父级"
    }, */
  { isOperate: true, label: i18n.t(`table.actions`), actions: ["detail", "edit", "deleted"] } //操作列
];

export const DeviceTypeEnumTypes: Array<any> = [
  { Text: "采集组", Value: "Group" },
  { Text: "采集点", Value: "Device" }
];

