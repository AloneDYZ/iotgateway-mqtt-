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
        key: "DriverName",
        label: "驱动名"
    },
    {
        key: "FileName",
        label: "文件名"
    },
    {
        key: "AssembleName",
        label: "程序集名"
    },
    {
        key: "AuthorizesNum",
        label: "剩余授权数量"
    },
  { isOperate: true, label: i18n.t(`table.actions`), actions: ["detail", "edit", "deleted"] } //操作列
];


