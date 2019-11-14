<template>
  <nm-form-dialog ref="form" v-bind="form" v-on="on" :visible.sync="visible_">
    <el-row>
      <el-col :span="20" :offset="1">
        <el-form-item label="文章编号：" prop="articleId">
          <el-input v-model="form.model.articleId" clearable/>
        </el-form-item>
        <el-form-item label="类型：" prop="type">
          <el-input v-model="form.model.type" clearable/>
        </el-form-item>
        <el-form-item label="链接：" prop="url">
          <el-input v-model="form.model.url" clearable/>
        </el-form-item>
        <el-form-item label="是否外链：" prop="outsideLink">
          <el-input v-model="form.model.outsideLink" clearable/>
        </el-form-item>
        <el-form-item label="MD5值：" prop="mD5">
          <el-input v-model="form.model.mD5" clearable/>
        </el-form-item>
      </el-col>
    </el-row>
  </nm-form-dialog>
</template>
<script>
import { mixins } from 'netmodular-ui'

const api = $api.blog.media

export default {
  mixins: [mixins.dialog],
  data () {
    return {
      form: {
        title: '添加多媒体',
        icon: 'add',
        action: api.add,
        model: {
          /** 文章编号 */
          articleId: '',
          /** 类型 */
          type: '',
          /** 链接 */
          url: '',
          /** 是否外链 */
          outsideLink: '',
          /** MD5值 */
          mD5: ''
        },
        rules: {
        }
      },
      on: {
        success: this.onSuccess,
        open: this.onOpen
      }
    }
  },
  methods: {
    onSuccess () {
      this.$emit('success')
    },
    onOpen () {
      this.$nextTick(() => {
        this.$refs.form.reset()
      })
    }
  }
}
</script>
