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
import { DeviceTypeEnumTypes } from "../config";

@Component({
    mixins: [formMixin()]
})
export default class Index extends Vue {
    @Action
    getDriver;
    @State
    getDriverData;
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
             "Entity.DeviceName":{
                 label: "名称",
                 rules: [],
                    type: "input"
            },
             "Entity.DeviceTypeEnum":{
                 label: "类型",
                 rules: [{ required: true, message: "类型"+this.$t("form.notnull"),trigger: "blur" }],
                    type: "select",
                    children: DeviceTypeEnumTypes,
                    props: {
                        clearable: true
                    }
            },
             "Entity.Index":{
                 label: "排序",
                 rules: [{ required: true, message: "排序"+this.$t("form.notnull"),trigger: "blur" }],
            },
             "Entity.Description":{
                 label: "描述",
                 rules: [],
                    type: "input"
            },
             "Entity.DriverId":{
                 label: "驱动",
                 rules: [],
                    type: "select",
                    children: this.getDriverData,
                    props: {
                        clearable: true
                    }
            },
             "Entity.AutoStart":{
                 label: "启动",
                 rules: [{ required: true, message: "启动"+this.$t("form.notnull"),trigger: "blur" }],
                    type: "switch"
            },
             "Entity.CgUpload":{
                 label: "变化上传",
                 rules: [{ required: true, message: "变化上传"+this.$t("form.notnull"),trigger: "blur" }],
                    type: "switch"
            },
             "Entity.EnforcePeriod":{
                 label: "归档周期ms",
                 rules: [{ required: true, message: "归档周期ms"+this.$t("form.notnull"),trigger: "blur" }],
            },
             "Entity.ParentId":{
                 label: "父级",
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
        this.getDriver();
        this.getDevice();

    }
}
</script>
