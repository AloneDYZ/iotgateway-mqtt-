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
import { IoTPlatformTypeTypes } from "../config";

@Component({
    mixins: [formMixin()]
})
export default class Index extends Vue {

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
             "Entity.GatewayName":{
                 label: "网关名称",
                 rules: [],
                    type: "input"
            },
             "Entity.MqttIp":{
                 label: "Mqtt服务器",
                 rules: [],
                    type: "input"
            },
             "Entity.MqttPort":{
                 label: "Mqtt端口",
                 rules: [{ required: true, message: "Mqtt端口"+this.$t("form.notnull"),trigger: "blur" }],
                    type: "input"
            },
             "Entity.MqttUName":{
                 label: "Mqtt用户名",
                 rules: [],
                    type: "input"
            },
             "Entity.MqttUPwd":{
                 label: "Mqtt密码",
                 rules: [],
                    type: "input"
            },
             "Entity.IoTPlatformType":{
                 label: "输出平台",
                 rules: [{ required: true, message: "输出平台"+this.$t("form.notnull"),trigger: "blur" }],
                    type: "select",
                    children: IoTPlatformTypeTypes,
                    props: {
                        clearable: true
                    }
            }
                
            }
        };
    }
    beforeOpen() {

    }
}
</script>
