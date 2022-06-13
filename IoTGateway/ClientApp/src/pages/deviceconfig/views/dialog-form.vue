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
import { DataSideTypes } from "../config";

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
             "Entity.DeviceConfigName":{
                 label: "名称",
                 rules: [],
                    type: "input"
            },
             "Entity.DataSide":{
                 label: "属性侧",
                 rules: [{ required: true, message: "属性侧"+this.$t("form.notnull"),trigger: "blur" }],
                    type: "select",
                    children: DataSideTypes,
                    props: {
                        clearable: true
                    }
            },
             "Entity.Description":{
                 label: "描述",
                 rules: [],
                    type: "input"
            },
             "Entity.Value":{
                 label: "值",
                 rules: [],
                    type: "input"
            },
             "Entity.EnumInfo":{
                 label: "备注",
                 rules: [],
                    type: "input"
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
