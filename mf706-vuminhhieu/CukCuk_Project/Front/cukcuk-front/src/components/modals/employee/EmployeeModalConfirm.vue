<template>
<BaseModalConfirm ref="BaseModalConfirm_ref">
  <p>{{message}}</p>
</BaseModalConfirm>
</template>

<script>
 import BaseModalConfirm from "../BaseModalConfirm.vue"
export default {
  props: {
    
    message : String
    },
  data() {
    return {
      visible: true,     
    };
  },
 components: {
   BaseModalConfirm
 },
  methods: {
    hide() {
     
      this.$refs.BaseModalConfirm_ref.hide();
    },
    show: async function() {       
        await this.$refs.BaseModalConfirm_ref.show(); 
    },

   
  },
};
</script>

<style src="../modal.scss" lang="scss" />
