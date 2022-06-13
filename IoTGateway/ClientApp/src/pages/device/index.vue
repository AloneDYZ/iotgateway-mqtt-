<template>
    <card>
        <wtm-search-box :ref="searchRefName" :events="searchEvent" :formOptions="SEARCH_DATA" :needCollapse="true" :isActive.sync="isActive" />
        <!-- 操作按钮 -->
        <wtm-but-box :assembly="assembly" :action-list="actionList" :selected-data="selectData" :events="actionEvent" />
        <!-- 列表 -->
        <wtm-table-box :attrs="{...searchAttrs, actionList}" :events="{...searchEvent, ...actionEvent}":default-expand-all="true" :row-key="'ID'" :tree-props="{children: 'children'}" :data="treeData">
      <template #AutoStart="rowData">
        <el-switch :value="rowData.row.AutoStart === 'true' || rowData.row.AutoStart === true" disabled />
      </template>

      <template #CgUpload="rowData">
        <el-switch :value="rowData.row.CgUpload === 'true' || rowData.row.CgUpload === true" disabled />
      </template>


        </wtm-table-box>
        <!-- 弹出框 -->
        <dialog-form :is-show.sync="dialogIsShow" :dialog-data="dialogData" :status="dialogStatus" @onSearch="onHoldSearch" />
        <!-- 导入 -->
        <upload-box :is-show.sync="uploadIsShow" @onImport="onImport" @onDownload="onDownload" />
    </card>
</template>

<script lang="ts">
import { Component, Vue } from "vue-property-decorator";
import { Action, State } from "vuex-class";
import searchMixin from "@/vue-custom/mixin/search";
import actionMixin from "@/vue-custom/mixin/action-mixin";
import DialogForm from "./views/dialog-form.vue";
import store from "./store/index";
// 查询参数, table列 ★★★★★
import { ASSEMBLIES, TABLE_HEADER,  } from "./config";
import i18n from "@/lang";

@Component({
    name: "device",
    mixins: [searchMixin(TABLE_HEADER), actionMixin(ASSEMBLIES)],
    store,
    components: {
        DialogForm
    }
})
export default class Index extends Vue {
    isActive: boolean = false;
    @Action
    getDriver;
    @State
    getDriverData;

    get SEARCH_DATA() {
        return {
            formProps: {
                "label-width": "75px",
                inline: true
            },
            formItem: {
                "DeviceName":{
                    label: "名称",
                    rules: [],
                    type: "input"
              },
                "DriverId":{
                    label: "Driver",
                    rules: [],
                    type: "select",
                    children: this.getDriverData,
                    props: {
                        clearable: true,
                        placeholder: '全部'
                    }
              },

            }
        };
    }

     mounted() {
        this.getDriver();

    }

    // tabledata转tree格式
    get treeData() {
        const list = this["tableData"];
        const getChilders = (pid, children = []) => {
            _.filter(list, ["ParentId", pid]).map(item => {
                const itemChild = getChilders(item.ID, item.children);
                children.push({ ...item, children: itemChild });
            });
            return children;
        };
        const tree = getChilders("", []);
        return tree;
    }
}
</script>
