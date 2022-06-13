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
             "Entity.DriverName":{
                 label: "驱动名",
                 rules: [],
                    type: "input"
            },
             "Entity.FileName":{
                 label: "文件名",
                 rules: [],
                    type: "input"
            },
             "Entity.AssembleName":{
                 label: "程序集名",
                 rules: [],
                    type: "input"
            },
             "Entity.AuthorizesNum":{
                 label: "剩余授权数量",
                 rules: [{ required: true, message: "剩余授权数量"+this.$t("form.notnull"),trigger: "blur" }],
                    type: "input"
            }
                
            }
        };
    }
    beforeOpen() {

    }
}
</script>
