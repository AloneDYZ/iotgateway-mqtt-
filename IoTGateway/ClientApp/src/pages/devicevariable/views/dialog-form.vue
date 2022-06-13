<template>
    <wtm-dialog-box :is-show.sync="isShow" :status="status" :events="formEvent">
        <wtm-create-form :ref="refName" :status="status" :options="formOptions" ></wtm-create-form>
    </wtm-dialog-box>
</template>

<script lang="ts">
import { Component, Vue } from "vue-property-decorator";
import { Action, State } from "vuex-class";
import formMixin from "@/vue-custom/mixin/form-mixin";
import UploadImg from "@/components/page/UploadImg.vue";
import { DataTypeTypes,ProtectTypeTypes } from "../config";

@Component({
    mixins: [formMixin()]
})
export default class Index extends Vue {
    @Action
    getDevice;
    @State
    getDeviceData;

    // 表单结构
    get formOptions() {
        const filterMethod = (query, item) => {
            return item.label.indexOf(query) > -1;
        };
        return {
            formProps: {
                "label-width": "100px"
            },
            formItem: {
                "Entity.ID": {
                    isHidden: true
                },
             "Entity.Name":{
                 label: "变量名",
                 rules: [],
                    type: "input"
            },
             "Entity.Description":{
                 label: "描述",
                 rules: [],
                    type: "input"
            },
             "Entity.Method":{
                 label: "方法",
                 rules: [],
                    type: "input"
            },
             "Entity.DeviceAddress":{
                 label: "地址",
                 rules: [],
                    type: "input"
            },
             "Entity.DataType":{
                 label: "类型",
                 rules: [{ required: true, message: "类型"+this.$t("form.notnull"),trigger: "blur" }],
                    type: "select",
                    children: DataTypeTypes,
                    props: {
                        clearable: true
                    }
            },
             "Entity.Expressions":{
                 label: "表达式",
                 rules: [],
                    type: "input"
            },
             "Entity.ProtectType":{
                 label: "权限",
                 rules: [{ required: true, message: "权限"+this.$t("form.notnull"),trigger: "blur" }],
                    type: "select",
                    children: ProtectTypeTypes,
                    props: {
                        clearable: true
                    }
            },
             "Entity.DeviceId":{
                 label: "Device",
                 rules: [],
                    type: "select",
                    children: this.getDeviceData,
                    props: {
                        clearable: true
                    }
            }
                
            }
        };
    }
    beforeOpen() {
        this.getDevice();

    }
}
</script>
